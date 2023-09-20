using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtsAnalyser.Model.ObservableClasses.Reliq
{
    public class ObservableReliqSet : ObservableSet
    {
        [Browsable(true)]
        [DisplayName("Планарный сет")]
        [Description("Является ли сет планарным")]
        new public bool planary { get; set; }
    }
}
