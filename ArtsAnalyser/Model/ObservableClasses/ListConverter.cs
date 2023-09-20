using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using ArtsAnalyser.Model.LocalCopiesOfDb;

namespace ArtsAnalyser.Model.ObservableClasses
{
    public class ListConverter : TypeConverter
    {
        public int Var { get; set; }
        public List<string> List { get; set; }
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new List<string>());
        }
    }

    public class TypeArtConverter: ListConverter
    {
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new List<string>(DbArtInWork.Types.Select(n => n.name).ToList()));
        }
    }

    public class SetArtConverter : ListConverter
    {
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new List<string>(DbArtInWork.Sets.Select(n => n.name).ToList()));
        }
    }

    public class UpStatesIssueConverter: ListConverter
    {
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) => new StandardValuesCollection(new List<string>() { string.Empty });
    }

    public class UpStatesArtConverter : UpStatesIssueConverter
    {
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            var tempUpStatesCol = from n in DbArtInWork.States
                       join m in DbArtInWork.StatesIsUpStates 
                        on n.id equals m.id
                       select new { name = n.name };
            if (tempUpStatesCol != null && tempUpStatesCol.Any())
                return new StandardValuesCollection(new List<string>(tempUpStatesCol.Select(n => n.name).ToList()));

            else
                return new StandardValuesCollection(new List<string>() { string.Empty });
        }
    }

    public class UpStateReliqConverter : UpStatesIssueConverter
    {
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            if (DbRelicsInWork.States != null && DbRelicsInWork.States.Any())
                return new StandardValuesCollection(new List<string>(DbRelicsInWork.States.Where(n=> n.isupstate == true).Select(n => n.name).ToList()));

            else
                return new StandardValuesCollection(new List<string>() { string.Empty });
        }
    }

    public class SubstatesArtConverter: ListConverter
    {
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new List<string>(DbArtInWork.States.Select(n => n.name).ToList()));
        }
    }
}
