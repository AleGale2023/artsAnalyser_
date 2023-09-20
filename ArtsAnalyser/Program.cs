
using ArtsAnalyser.Controller;
using ArtsAnalyser.Controller.MainControllerInheritors;

namespace ArtsAnalyser
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            bool isConf = false;
            bool isArt = false;

            DbChooseForm dbChooseForm = new DbChooseForm();
            dbChooseForm.Choosen += (askDb) =>
            {
                isArt = askDb;
                isConf = true;

                MainForm mainView = new MainForm();
                NewArtView addInstView = new NewArtView();
                mainView.Hide();
                AddController addArtController = new AddController(mainView, addInstView, isArt);
                MainController mainController = new MainRelController(mainView, addArtController);
                //--------?
                addInstView.SetController(addArtController);

                mainController.LoadView();
                dbChooseForm.Hide();
                mainView.FormClosing += dbChooseForm.Close;
                mainView.ShowDialog();
            };
            dbChooseForm.ShowDialog();
        }
    }

   
}