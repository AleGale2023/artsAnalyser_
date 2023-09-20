using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DbReliques;
using Type = DbReliques.Type;
using ArtsAnalyser.Model.LocalCopiesOfDb;
using ArtsAnalyser.Model.ObservableClasses.Reliq;

namespace ArtsAnalyser.Model.ObservableClasses.Saver
{
    public class ObservableDataSaverReliq
    {

        public static void SaveData(object obj)
        {
            if (obj is ObservableSet)
                ObservableDataSaverReliq.SaveSet(obj as ObservableReliqSet);
            if (obj is ObservableType)
                ObservableDataSaverReliq.SaveType(obj as ObservableReliqType);
            if (obj is ObservableState)
                ObservableDataSaverReliq.SaveState(obj as ObservableState);
        }

        public static void SaveSet(ObservableReliqSet set)
        {
            var tmpInst = new Set();
            tmpInst.name = set.Name;
            tmpInst.islegendary = set.IsLegendary;
            tmpInst.id = DbArtInWork.Sets.Count + 1;
            tmpInst.effect2 = set.Effect2;
            tmpInst.effect4 = set.Effect4;

            DbArtInWork.Save<Set>(new List<Set>() { tmpInst });
        }

        public static void SaveType(ObservableReliqType type)
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

