using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtsAnalyser.Controller.ViewInterfaces;
using ArtsAnalyser.Model;
using ArtsAnalyser.Model.LocalCopiesOfDb;

namespace ArtsAnalyser.Controller.MainControllerInheritors
{
    internal class MainArtController : MainController
    {
        internal MainArtController(IInstanceAnalyserView view, INewInstanceController newIssueView) : base(view, newIssueView) => LoadDB();

        internal virtual void LoadDB() => DbArtInWork.LoadDB();


        public override void LoadView()
        {
            //тут загрузка артов через модель и их вывод в dgv на view
            {
                var arts = DbArtInWork.Arts;
                foreach (var art in arts)
                {
                    AskFormer ask = new AskType();
                    string id = art.id.ToString();
                    string type = ask.GetNameByID(art.idtype);
                    ask = new AskSet();
                    string set = ask.GetNameByID(art.idset);
                    ask = new AskState();
                    string state = ask.GetNameByID(art.idupstate);
                    string level = art.level.ToString();
                    string critmass = art.critmass.ToString();
                    string est = art.est.ToString();
                    bool isLeg = art.isgold;

                    IInstanceToView tmpArt = new ArtToView(id, type, state, level, set,
                        critmass, est, isLeg);
                }
            }
        }
    }
}
