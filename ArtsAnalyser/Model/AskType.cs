using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbArts;

using Type = DbArts.Type;
using ArtsAnalyser.Model.LocalCopiesOfDb;

namespace ArtsAnalyser
{
    internal class AskType : AskFormer
    {
        List<Type> types;
        public AskType() : base()
        {
        }

        public override int GetIDByName(string name)
        {
                int id = 0;
                if (DbArtInWork.Types != null && DbArtInWork.Types.Any())
                    id = DbArtInWork.Types.Where(s => s.name == name).First().id;

                return id;
        }

        public override string GetNameByID(int id)
        {
            if (id < 1)
                return String.Empty;

            string name = String.Empty;
            if (DbArtInWork.Types != null && DbArtInWork.Types.Any())
                name = DbArtInWork.Types.Where(s => s.id == id).First().name;

            return name;
        }
    }
}
