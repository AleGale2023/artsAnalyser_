using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtsAnalyser
{
    //отображение основной таблицы сущностей
    //дубль observable classes, переделать
    //лучше всего превратить его в интерфейс
    public interface IInstanceToView
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public string Level { get; set; }
        public string Set { get; set; }
        public string Critmass { get; set; }
        public string Est { get; set; }

        public bool IsLegendary { get; set; }
    }
}
