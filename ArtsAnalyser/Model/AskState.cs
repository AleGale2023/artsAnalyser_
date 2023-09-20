using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DbArts;
using Type = DbArts.Type;
using ArtsAnalyser.Model.LocalCopiesOfDb;

namespace ArtsAnalyser.Model
{
    public class AskState : AskFormer
    {
        List<State> states;
        List<TypeUpValue> typeUpSt;
        List<Type> types;

        public AskState() : base()
        {
            states = DbArtInWork.States;
            typeUpSt = DbArtInWork.TypeUpVals;
            types = DbArtInWork.Types;
        }


        public override int GetIDByName(string name)
        {
            if (name == String.Empty)
                return 0;

            if (states != null && states.Any())
                return states.ToList().Where(s => s.name == name).First().id;

            return 0;
        }

        public override string GetNameByID(int id)
        {
            if (id < 1)
                return String.Empty; 
            if (states != null && states.Any())
                return states.ToList().Where(s => s.id == id).First().name;

            return String.Empty;
        }

        public List<string> GetUpStates(string typeName)
        {
            var typesUPValuesExt =
                from state in states
                join typeUpValue in typeUpSt
                on state.id equals typeUpValue.idupstate
                join type in types
                on typeUpValue.idtype equals type.id
                select new
                {
                    IDType = type.id,
                    IDState = state.id,
                    Type = type.name,
                    UpState = state.name
                };

            return typesUPValuesExt.Where(t => t.Type == typeName).Select(s => s.UpState).ToList();
        }

        public List<string> GetAllStates(bool isNeedSubstates)
        {
            List<string> stateNames = null;
            if (isNeedSubstates == true)
                stateNames = states.Where(s => s.issubst == true).Select(s => s.name).ToList();
            else
                stateNames = states.Select(s => s.name).ToList();

            return stateNames;
        }


    }
}
