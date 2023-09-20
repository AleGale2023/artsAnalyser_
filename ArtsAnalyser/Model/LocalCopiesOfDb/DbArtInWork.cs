using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbArts;
using Type = DbArts.Type;
using ApplicationContext = DbArts.ApplicationContext;

namespace ArtsAnalyser.Model.LocalCopiesOfDb
{
    //класс для взятия и сохранения локальной копии бд
    internal class DbArtInWork
    {
        public static List<Set> Sets { get; set; }
        public static List<State> States { get; set; }
        public static List<StateIsUpState> StatesIsUpStates { get; set; }
        public static List<Type> Types { get; set; }
        public static List<Art> Arts { get; set; }
        public static List<TypeUpValue> TypeUpVals { get; set; }
        public static List<UpStateValueLeg> UpStVlLegs { get; set; }
        public static List<Substates> Substates { get; set; }

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
                if (db.StateIsUpState != null && db.StateIsUpState.Any())
                    StatesIsUpStates = db.StateIsUpState.ToList();
                if (db.Substates != null && db.Substates.Any())
                    Substates = db.Substates.ToList();
                if (db.Arts != null && db.Arts.Any())
                    Arts = db.Arts.ToList();
                if (db.UpStateValueLeg != null && db.UpStateValueLeg.Any())
                    UpStVlLegs = db.UpStateValueLeg.ToList();
                if (db.TypeUpValue != null && db.TypeUpValue.Any())
                    TypeUpVals = db.TypeUpValue.ToList();
            }
        }

        internal static void Save<T>(List<T> t)
        {
            using (ApplicationContext db = new ApplicationContext())
                db.Add(t);
        }

    }
}
