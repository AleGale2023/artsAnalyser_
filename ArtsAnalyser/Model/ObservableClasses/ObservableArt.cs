using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using ArtsAnalyser.Model.LocalCopiesOfDb;

namespace ArtsAnalyser.Model.ObservableClasses
{
    public class ObservableArt : DbArts.Art
    {
      //  [Browsable(false)]
        public new int id { get; set; }
        [Browsable(false)]
        public new int idset { get; set; }
        [Browsable(false)]
        public new int idupstate { get; set; }
        [Browsable(false)]
        public new int idtype { get; set; }

        [Browsable(true)]
        [DisplayName("Тип")]
        [Description("")]
        [Category("Основные параметры")]
        public List<string> Type
        {
            get
            {
                return new List<string>(DbArtInWork.Types.Select(s => s.name).ToList());
            }
            set
            { }
        }

        [Browsable(true)]
        [DisplayName("Верхний стат")]
        [Description("Тип верхнего стата артефакта\n" +
            "Для цветка: хп\n" +
            "Для пера: са\n" +
            "Для часов: процент хп, процент са, вэ, процент защиты, процент хп, мс\n" +
            "Для кубка: бонус элементального урона, мс, процент са, процент защита, процент хп\n" +
            "Для шапки: бонус лечения, крит шанс, крит урон, процент защиты, процент хп, мс")]
        [Category("Основные параметры")]
        public List<string> StateList
        {
            get
            {
                return new List<string>(DbArtInWork.States.Select(n => n.name).ToList());
            }
            set
            { }
        }

        [Browsable(false)]
        ComboBox state = new ComboBox();

        [Browsable(true)]
        [DisplayName("Сет")]
        [Description("Название сета артефактов")]
        [Category("Основные параметры")]
        public List<string> Set
        {
            get
            {
                return new List<string>(DbArtInWork.Sets.Select(n => n.name).ToList());
            }
            set { }
        }

        [Browsable(true)]
        [DisplayName("Уровень")]
        [Description("Для легендарного артефакта - до 20/nдля эпического - до 16")]
        [Category("Основные параметры")]
        public new int level { get; set; }

        [Browsable(true)]
        [DisplayName("Оценка")]
        [Description("Показатель полезности на основе сета и подстатов")]
        [Category("Вычисляемые параметры")]
        public new int est { get; set; }

        [Browsable(true)]
        [DisplayName("Крит масса")]
        [Description("Рассчитывается по формуле ку + 2* кш")]
        [Category("Вычисляемые параметры")]
        public new int critmass { get; set; }


        [Browsable(true)]
        [DisplayName("Легендарный")]
        [Description("Артефакт легендарный или эпический")]
        [Category("Основные параметры")]
        public new bool IsGold{ get; set; }


        /*добавка подстатов как обсервабл коллекшн*/

    }
}
