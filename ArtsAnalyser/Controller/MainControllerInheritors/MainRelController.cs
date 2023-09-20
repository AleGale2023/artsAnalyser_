using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArtsAnalyser.Model.LocalCopiesOfDb;
using ArtsAnalyser.Model;
using ArtsAnalyser.Controller.ViewInterfaces;

namespace ArtsAnalyser.Controller.MainControllerInheritors
{
    internal class MainRelController : MainController
    {
        public MainRelController(IInstanceAnalyserView view, INewInstanceController newIssueView) : base(view, newIssueView) => LoadDB();

        public virtual void LoadDB() => DbRelicsInWork.LoadDB();


        public override void LoadView()
        {


            //тут загрузка артов через модель и их вывод в dgv на view
            {
                var reliqs = DbRelicsInWork.Reliques;
                foreach (var reliq in reliqs)
                {
                    AskFormer ask = new AskType();
                    string id = reliq.id.ToString();
                    string type = ask.GetNameByID(reliq.idtype);
                    ask = new AskSet();
                    string set = ask.GetNameByID(reliq.idset);
                    ask = new AskState();
                    string state = ask.GetNameByID(reliq.idupstate);
                    string level = reliq.level.ToString();
                    string critmass = reliq.critmass.ToString();
                    string est = reliq.est.ToString();
                    bool isLeg = reliq.isgold;

                    IInstanceToView tmpArt = new RelToView(id, type, state, level, set,
                        critmass, est, isLeg);
                }

                //var tmpSet = new DbReliques.Set();
                //tmpSet.name = "Золотая труппа";
                //tmpSet.effect2 = "Увеличивает силу обычной и заряженной атаки на 12%";
                //tmpSet.effect4 = "Увеличивает шанс крит попадания на 8% после потери хп на 10 сек.";
                //tmpSet.islegendary = true;
                //tmpSet.id = DbRelicsInWork.Sets.Count + 1;
                //DbRelicsInWork.SaveSet(new List<DbReliques.Set>() { tmpSet });
            }
        }
    }

}