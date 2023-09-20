using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ArtsAnalyser.Controller;
using ArtsAnalyser.Model.ObservableClasses;
using ArtsAnalyser.Model.ObservableClasses.Reliq;

namespace ArtsAnalyser
{
    public partial class NewArtView : Form
    {
        AddController controller;
        Object obj;

        public NewArtView()
        {
            InitializeComponent();
        }

        public void SetController(AddController addController)
        {
            controller = addController;
            bAddValueToList.Click += new EventHandler(controller.AddTypeHandler);
            bClose.Click += new EventHandler(controller.AddViewCloseHandler);
            bSave.Click += new EventHandler(controller.SaveViewDataHandler);
        }

        public void LoadObj(Object obj)
        {
            this.obj = obj;
            instancePropGrid.SelectedObject = obj;
            if (obj is ObservableReliqType && obj != null)
            {
                cbValuesList.DataBindings.Add("Name", (obj as ObservableType).UpStatesList, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        
        public void NewArtView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #region Hide/Show extra width
        public void HideExtra()
        {
            bAddValueToList.Hide();
            cbValuesList.Hide();
            this.Width = 453;
        }

        public void ShowExtra()
        {
            bAddValueToList.Show();
            cbValuesList.Show();
            this.Width = 610;
        }
        #endregion

    }
}
