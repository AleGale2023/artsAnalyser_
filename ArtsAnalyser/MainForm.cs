using ArtsAnalyser.Controller;
using ArtsAnalyser.Controller.ViewInterfaces;

namespace ArtsAnalyser
{
    public partial class MainForm : Form, IInstanceAnalyserView
    {
        MainController controller;
        public MainForm()
        {
            InitializeComponent();
        }

        public void SetController(MainController controller)
        {
            this.controller = controller;

            this.bShow.Click += new System.EventHandler(controller.ShowArtHandler);
            this.bRemove.Click += new System.EventHandler(controller.RemoveArtHandler);
            this.bAdd.Click += new System.EventHandler(controller.AddArtHandler);
            this.bExit.Click += new System.EventHandler(controller.ExitHandler);
            this.bRemove.Click += new System.EventHandler(controller.RemoveArtHandler);
            this.âûõîäToolStripMenuItem1.Click += new System.EventHandler(controller.ExitHandler);
            this.âûõîäToolStripMenuItem.Click += new System.EventHandler(controller.ExitHandler);
            this.ñåòÀðòåôàêòîâToolStripMenuItem.Click += new System.EventHandler(controller.AddSetHandler);
            this.òèïÀðòåôàêòàToolStripMenuItem.Click += new System.EventHandler(controller.AddTypeHandler);
            this.âåðõíèéÑòàòToolStripMenuItem.Click += new System.EventHandler(controller.AddStateHandler);
            this.àðòåôàêòToolStripMenuItem.Click += new System.EventHandler(controller.AddArtHandler);
        }
        public void ClearGrid() { }
        public void ShowArtefact(RelToView art)
        {
            if (dgvArts.Rows.Count > 1)
                dgvArts.Rows.Add();
            int index = dgvArts.Rows.Count - 1;
            dgvArts.Rows[index].Cells[0].Value = art.ID;
            dgvArts.Rows[index].Cells[1].Value = art.Type;
            dgvArts.Rows[index].Cells[2].Value = art.State;
            dgvArts.Rows[index].Cells[3].Value = art.Level;
            dgvArts.Rows[index].Cells[4].Value = art.Set;
            dgvArts.Rows[index].Cells[5].Value = art.Critmass;
            dgvArts.Rows[index].Cells[6].Value = art.Est;
            dgvArts.Rows[index].Cells[7].Value = art.IsLegendary;
        }

        public void RemoveArtefact(RelToView art) { }
        public void SetSelectedArtefact(RelToView art) { }

        public DataGridViewRow GetSelectedRow()
        {
            Int32 selectedCellCount =
       dgvArts.GetCellCount(DataGridViewElementStates.Selected);
            DataGridViewRow dr = dgvArts.Rows[dgvArts.SelectedCells[0].RowIndex];
            return dr;    
        }
    }
}