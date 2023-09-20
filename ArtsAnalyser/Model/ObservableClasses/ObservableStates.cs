using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace ArtsAnalyser.Model.ObservableClasses
{
    public class ObservableState
    {
        [Browsable(true)]
        [DisplayName("Стат")]
        [Description("Доступный стат (хп/са...)")]
        new public string Name { get; set; }

        [Browsable(true)]
        [DisplayName("Подстат")]
        [Description("Является ли стат подстатом")]
        new public bool IsSubst { get; set; } = true;

        [Browsable(true)]
        [DisplayName("Верхний стат")]
        [Description("Является ли стат верхним статом")]
        new public bool IsUpState { get; set; } = true;

        [Browsable(true)]
        [DisplayName("Доступные верхние статы")]
        [Description("Доступные верхние статы артефактов")]
        public List<string> UpStates { get; }
    }
}
