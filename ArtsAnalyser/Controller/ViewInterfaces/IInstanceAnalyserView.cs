using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtsAnalyser.Controller.ViewInterfaces
{
    public interface IInstanceAnalyserView
    {
        public void SetController(MainController controller);
        public void ClearGrid();
        public void ShowArtefact(RelToView art);
        public DataGridViewRow GetSelectedRow();
        public void RemoveArtefact(RelToView art);
        public void SetSelectedArtefact(RelToView art);
    }
}
