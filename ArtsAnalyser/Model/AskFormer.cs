using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtsAnalyser
{
    public abstract class AskFormer : IDisposable
    {
        public abstract int GetIDByName(string name);
        public abstract string GetNameByID(int id);

        public void Dispose() { }
    }
}
