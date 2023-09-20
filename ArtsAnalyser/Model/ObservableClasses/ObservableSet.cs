using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtsAnalyser.Model.ObservableClasses
{
    public class ObservableSet
    {
        [Browsable(true)]
        [DisplayName("Название сета")]
        [Description("Название сета артефактов")]
        new public string Name { get; set; }

        [Browsable(true)]
        [DisplayName("Эффект 2 артефактов")]
        [Description("Эффект 2 артефактов из сета")]
        public string Effect2 { get; set; }

        [Browsable(true)]
        [DisplayName("Эффект 4 артефактов")]
        [Description("Эффект 4 артефактов из сета")]
        public string Effect4 { get; set; }

        [Browsable(true)]
        [DisplayName("Легендарный")]
        [Description("Проверка легендарности сета")]
        new public bool IsLegendary { get; set; } = true;

    }
}
