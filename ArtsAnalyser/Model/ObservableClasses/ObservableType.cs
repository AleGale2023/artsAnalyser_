using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace ArtsAnalyser.Model.ObservableClasses
{
    public class ObservableType: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        [Browsable(true)]
        [DisplayName("Название типа")]
        [Description("Название типа артефактов (цветок/перо...)")]
        new public string Name{ get; set; }

        [Browsable(true)]
        [DisplayName("Доступные верхние статы")]
        [Description("Доступные верхние статы артефактов")]
        [TypeConverter(typeof(UpStatesIssueConverter))]
        public virtual string UpStates{ get; set; }

        public List<string> upStatesList = new List<string>();
        [Browsable(true)]
        [DisplayName("Список верхних статов")]
        public List<string> UpStatesList
        {
            get { return upStatesList; }
            set
            {
                upStatesList = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void Refresh()
        {
            OnPropertyChanged("UpStatesList");
        }
    }


}
