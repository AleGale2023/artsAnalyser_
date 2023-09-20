using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ArtsAnalyser.Controller.ViewInterfaces;
using ArtsAnalyser.Model.ModelMaintenance;

namespace ArtsAnalyser.Controller
{


    public abstract class MainController
    {
        ModelMaintenance modelMain = ModelMaintenance.GetInstance();

        bool isArt { get; set; } = false;
        IInstanceAnalyserView mainView;
        INewInstanceController newInstanceController;

        Object selectedIssue;

        public MainController(IInstanceAnalyserView view, INewInstanceController newInstanceController)
        {
            if (view == null)
                Application.Exit();

            this.mainView = view;
            this.newInstanceController = newInstanceController;

            view.SetController(this);
        }

        internal virtual void LoadDB() { }

        public virtual void LoadView() { }

        public void ExitHandler(object sender, EventArgs e) => Application.Exit();

        public void ShowArtHandler(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = mainView.GetSelectedRow();
                if (selectedRows != null)
                {
                    string id = selectedRows.Cells[0].Value.ToString();
                    //RelToView artSelected = arts.Where(a => a.ID == id).First();

                    //newArtView.LoadView(artSelected);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Что-то пошло не так", "Warning", MessageBoxButtons.OK);
            }
        }

        //у них же собственный контроллер!
        public void AddArtHandler(object sender, EventArgs e)
        {
            newInstanceController.LoadObj(TypeTable.Instance);
            
        }

        public void AddSetHandler(object sender, EventArgs e)
        {
            newInstanceController.LoadObj(TypeTable.Set);
        }

        public void AddTypeHandler(object sender, EventArgs e)
        {
            newInstanceController.LoadObj(TypeTable.Type);
        }

        public void AddStateHandler(object sender, EventArgs e)
        {
            newInstanceController.LoadObj(TypeTable.State);
        }

        public void RemoveArtHandler(object sender, EventArgs e) { }
    }
}

