using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArtsAnalyser.Model.ObservableClasses;
using ArtsAnalyser.Model.ObservableClasses.Art;
using ArtsAnalyser.Model.ObservableClasses.Reliq;

namespace ArtsAnalyser.Model.ModelMaintenance
{
    public enum TypeTable { Instance, Type, Set, State };

    public class ModelMaintenance
    {
        static ModelMaintenance instance = new ModelMaintenance();
        private ModelMaintenance() { }
        public static ModelMaintenance GetInstance() => instance;

        public delegate void GeneratedObjHandler(Object obj);
        public event GeneratedObjHandler? NotifyObjCreation;

        public void GenerateObj(TypeTable type, bool isArt)
        {
            Object generatedObj = null;
            switch (type)
            {
                case (int)TypeTable.Instance:
                    if (isArt)
                        generatedObj = new ObservableArt();
                    else
                    {
                        //var Issue = new ObservableReliq();
                    }
                        break;
                case TypeTable.Type:
                    if (isArt)
                        generatedObj = new ObservableArtType();
                    else
                        generatedObj = new ObservableReliqType();
                    break;
                case TypeTable.Set:
                    if (isArt)
                        generatedObj = new ObservableArtSet();
                    else
                        generatedObj = new ObservableReliqSet();
                    break;
                case TypeTable.State:
                    generatedObj = new ObservableState();
                    break;
            }
            NotifyObjCreation?.Invoke(generatedObj);

        }

    }
}
