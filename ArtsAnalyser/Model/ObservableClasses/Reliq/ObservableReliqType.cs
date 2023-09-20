using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ArtsAnalyser.Model.ObservableClasses.Reliq
{
    public class ObservableReliqType : ObservableType
    {
        [Browsable(true)]
        [DisplayName("Доступные верхние статы")]
        [Description("Доступные верхние статы артефактов")]
        [TypeConverter(typeof(UpStateReliqConverter))]
        public string UpStates { get; set; }
    }
}
