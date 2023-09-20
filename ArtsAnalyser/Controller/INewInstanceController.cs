using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArtsAnalyser.Model.ModelMaintenance;

namespace ArtsAnalyser.Controller
{
    public interface INewInstanceController
    {
        public object Obj { get; set; }
        public void LoadObj(TypeTable type);
    }
}
