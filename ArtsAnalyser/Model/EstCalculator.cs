using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbArts;

namespace ArtsAnalyser.Model
{
    internal class EstCalculator
    {
        public static double CalcCM(List<Substates> substs)
        {
            AskState askSt = new AskState();
            double critmass = 0;
            foreach (var subst in substs)
            {
                if (subst.idstate == askSt.GetIDByName("Крит урон"))
                    critmass += subst.value;
                if (subst.idstate == askSt.GetIDByName("Шанс крита"))
                    critmass += subst.value * 2;
            }
            return critmass;
        }

        public static double CalcEst()
        {
            double est = 0;
            return est;
        }
    }
}
