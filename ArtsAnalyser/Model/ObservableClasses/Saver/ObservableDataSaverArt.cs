using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DbArts;
using Type = DbArts.Type;
using ArtsAnalyser.Model.LocalCopiesOfDb;
using ArtsAnalyser.Model.ObservableClasses.Art;

namespace ArtsAnalyser.Model.ObservableClasses.Saver
{
    public class ObservableDataSaverArt 
    {
        public static void SaveData(object obj)
        {
            if (obj is ObservableSet)
                ObservableDataSaverArt.SaveSet(obj as ObservableArtSet);
            if (obj is ObservableType)
                ObservableDataSaverArt.SaveType(obj as ObservableArtType);
            if (obj is ObservableState)
                ObservableDataSaverArt.SaveState(obj as ObservableState);
        }

        public static void SaveSet(ObservableArtSet set)
        {
            var tmpInst = new Set();
            tmpInst.name = set.Name;
            tmpInst.islegendary = set.IsLegendary;
            tmpInst.id = DbArtInWork.Sets.Count + 1;
            tmpInst.effect2 = set.Effect2;
            tmpInst.effect4 = set.Effect4;

            DbArtInWork.Save<Set>(new List<Set>() { tmpInst });
        }

        public static void SaveType(ObservableType type)
        {
            var tmpInst = new Type();
            tmpInst.name = type.Name;
            tmpInst.id = DbArtInWork.Types.Count + 1;

            DbArtInWork.Save<Type>(new List<Type>() { tmpInst });
        }

        public static void SaveState(ObservableState state)
        {
            var tmpInst = new State();
            tmpInst.name = state.Name;
            tmpInst.id = DbArtInWork.Types.Count + 1;

            DbArtInWork.Save<State>(new List<State>() { tmpInst });
        }
    }
}
