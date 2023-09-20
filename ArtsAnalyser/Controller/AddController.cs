using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtsAnalyser.Model.ObservableClasses;
using ArtsAnalyser.Model.ModelMaintenance;
using ArtsAnalyser.Model.ObservableClasses.Reliq;
using ArtsAnalyser.Model.ObservableClasses.Art;
using ArtsAnalyser.Model.ObservableClasses.Saver;

namespace ArtsAnalyser.Controller
{
    public class AddController : INewInstanceController
    {
        bool isArt;
        Form parent;
        NewArtView view;
        ModelMaintenance modelMain = ModelMaintenance.GetInstance();

        public Object Obj { get; set; }

        public AddController(Form parent, NewArtView view, bool isArt)
        {
            if (parent == null)
                return;
            this.isArt = isArt;
            this.parent = parent;
            this.view = view;
        }

        public void LoadObj(TypeTable type)
        {
            modelMain.NotifyObjCreation += view.LoadObj;
            modelMain.GenerateObj(type, isArt);
            if (Obj is ObservableArtType == true || Obj is ObservableReliqType)
                view.ShowExtra();
            else
                view.HideExtra();
            view.Show();
        }

        public void AddTypeHandler(object sender, EventArgs e)
        {
            if (Obj is ObservableType == true)
            {
                var obsType = Obj as ObservableType;
                obsType.UpStatesList.Add(obsType.UpStates);
                obsType.Refresh();
            }
            if (Obj is ObservableSet == true)
            {
                var obsSet = Obj as ObservableSet;
            }
            if (Obj is ObservableState == true)
            {
                var obsState = Obj as ObservableState;
            }
        }

        public void AddViewCloseHandler(object sender, EventArgs e)
        {
            view.Close();
            modelMain.NotifyObjCreation -= view.LoadObj;
        }

        public void SaveViewDataHandler(object sender, EventArgs e)
        {
            ObservableDataSaverManager.SaveData(Obj, isArt);
        }


    }
}
