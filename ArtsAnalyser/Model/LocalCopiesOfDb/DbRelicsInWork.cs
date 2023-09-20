using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbReliques;
using Type = DbReliques.Type;
using ApplicationContext = DbReliques.ApplicationContext;

namespace ArtsAnalyser.Model.LocalCopiesOfDb
{
    internal class DbRelicsInWork
    {
        public static List<Set> Sets { get; set; } = new List<Set>();
        public static List<State> States { get; set; } = new List<State>();
        public static List<Type> Types { get; set; } = new List<Type>();
        public static List<Relique> Reliques { get; set; } = new List<Relique>();
        public static List<TypeUpValue> TypeUpVals { get; set; } = new List<TypeUpValue>();
        public static List<UpStateValue> UpStVl { get; set; } = new List<UpStateValue>();
        public static List<Substates> Substates { get; set; } = new List<Substates>();

        public static void LoadDB()
        {
            ReadDB();
        }

        internal static void ReadDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (db.Set != null && db.Set.Any())
                    Sets = db.Set.ToList();
                if (db.Type != null && db.Type.Any())
                    Types = db.Type.ToList();
                if (db.State != null && db.State.Any())
                    States = db.State.ToList();
                if (db.Substates != null && db.Substates.Any())
                    Substates = db.Substates.ToList();
                if (db.Relique != null && db.Relique.Any())
                    Reliques = db.Relique.ToList();
                if (db.UpStateValue != null && db.UpStateValue.Any())
                    UpStVl = db.UpStateValue.ToList();
                if (db.TypeUpValue != null && db.TypeUpValue.Any())
                    TypeUpVals = db.TypeUpValue.ToList();
            }
        }

        internal static void SaveSet(List<Set> sets)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Add(sets);
            }
        }

        internal static void SaveState(List<State> states)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Add(states);
            }
        }
    }
}
