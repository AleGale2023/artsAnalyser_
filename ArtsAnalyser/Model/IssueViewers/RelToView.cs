using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DbReliques;

namespace ArtsAnalyser
{
    public class RelToView : IInstanceToView
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public string Level { get; set; }
        public string Set { get; set; }
        public string Critmass { get; set; }
        public string Est { get; set; }

        public bool IsLegendary { get; set; }
        public bool IsPlanary { get; set; } = false;

        public List<Substates> Substates { get; set; } = new List<Substates>();

        internal RelToView(string id, string type, string state, string level,
            string set, string critmass, string est, bool isLeg, bool isPlanary = false)
        {
            ID = id;
            Type = type;
            State = state;
            Set = set;
            Level = level;
            Critmass = critmass;
            Est = est;
            IsLegendary = isLeg;
            IsPlanary = isPlanary;
        }
    }
    
}
