using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtsAnalyser;

using DbArts;
using ArtsAnalyser.Model.LocalCopiesOfDb;

namespace ArtsAnalyser.Model
{
    public class AskSet : AskFormer
    {
        readonly List<Set> sets;
        public AskSet() : base()
        {
            sets = DbArtInWork.Sets;
        }


        public override int GetIDByName(string name)
        {
            if (name == String.Empty)
                return 0;

            if (sets != null && sets.Any())
                return sets.ToList().Where(s => s.name == name).First().id;

            return 0;
        }

        public override string GetNameByID(int id)
        {
            if (id < 1)
                return String.Empty;

            if (sets != null && sets.Any())
                return sets.ToList().Where(s => s.id == id).First().name;

            return String.Empty;
        }

        public bool IsSetLegendary(string name)
        {
            if (name == String.Empty)
                return false;

            if (sets != null && sets.Any())
                return sets.Where(s => s.name == name).First().islegendary;

            return false;
        }

        public bool IsSetLegendary(int id)
        {
            if (id < 1)
                return false;

            if (sets != null && sets.Any())
                return sets.Where(s => s.id == id).First().islegendary;

            return false;
        }

        public List<Set> GetLegendarySetList()
        {
            if (sets != null && sets.Any())
                return sets.Where(s => s.islegendary == true).ToList();
            return null;
        }
    }
}
