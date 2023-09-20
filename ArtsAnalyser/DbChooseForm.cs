using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtsAnalyser
{
    public class RbBinding: INotifyPropertyChanged
    {
        private bool isArt;
        public bool IsArt
        {
            get { return isArt; }
            set
            {
                isArt = value;
                if (isReliq == value)
                {
                    isReliq = !value;
                    NotifyPropertyChanged("IsReliq");
                }
                NotifyPropertyChanged("IsArt");
            }
        }

        private bool isReliq;
        public bool IsReliq
        {
            get { return isReliq; }
            set
            {
                isReliq = value;
                if (isArt == value)
                {
                    isArt = !value;
                    NotifyPropertyChanged("IsArt");
                }
                NotifyPropertyChanged("IsReliq");
            }
        }


        //public bool cb1Enabled { get { return isArt; } }
        //public bool cb2Enabled { get { return isReliq; } }

        public RbBinding()
        {
            isReliq = true;
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string fieldName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(fieldName));
            }
        }

        #endregion
    }

    public partial class DbChooseForm : Form, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string fieldName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(fieldName));
            }
        }

        #endregion

        bool confirmed = false;
        bool isArt;

        public delegate void DbChoosen(bool isConf);
        public event DbChoosen? Choosen;
        RbBinding model = new RbBinding();


        public DbChooseForm()
        {
            InitializeComponent();

            BindingSource bindingSource = new BindingSource(model, "");
            rbArt.DataBindings.Add(new Binding("Checked", bindingSource, "IsArt", true, DataSourceUpdateMode.OnPropertyChanged));
            rbReliq.DataBindings.Add(new Binding("Checked", bindingSource, "IsReliq", true, DataSourceUpdateMode.OnPropertyChanged));

        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            isArt = model.IsArt;
            confirmed = true;
            Choosen?.Invoke(isArt);
        }

        public bool GetRes() => confirmed;


        public void Close (Object sender, FormClosingEventArgs e) => this.Close(); 

    }
}
