using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArtsAnalyser.Model.LocalCopiesOfDb;

namespace ArtsAnalyser.Model.ObservableClasses.Saver
{
    public class ObservableDataSaverManager
    {
        public static void SaveData(Object obj, bool isArt) 
        {
            if (isArt)
                ObservableDataSaverArt.SaveData(obj);
            else
                ObservableDataSaverReliq.SaveData(obj);
        }

        public static void SaveStateReliq(object obj)
        {
            var instanceToSave = obj as ObservableState;
            var tmpInst = new DbReliques.State();
            tmpInst.name = instanceToSave.Name;
            tmpInst.isupstate = instanceToSave.IsUpState;
            tmpInst.issubst = instanceToSave.IsSubst;

            tmpInst.id = DbRelicsInWork.States.Count + 1;
            DbRelicsInWork.SaveState(new List<DbReliques.State>() { tmpInst });
        }

    }
   
}
