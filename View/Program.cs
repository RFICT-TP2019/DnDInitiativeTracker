using System;
using System.Windows.Forms;
using Ninject;
using DAL;
using Model;
using Model.Entity;
using Model.Service;
using Presentation;
using View;

namespace DnDInitiativeTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ITimer>().To<WinFormTimer>();
            kernel.Bind<IInitiativeView>().To<InitiativeView>();
            kernel.Bind<ICharacterView>().To<CharacterView>();
            kernel.Bind<IAddInitiativeView>().To<AddInitiativeView>();
            kernel.Bind<IStatisticsView>().To<StatisticsView>();
            kernel.Bind<ICombatService>().To<CombatService>();
            kernel.Bind<ICharacterService>().To<CharacterService>();
            kernel.Bind<IAddInitiativeService>().To<AddInitiativeService>();
            kernel.Bind<IRepository<Character>>().To<CharacterRepository>();
            kernel.Bind<IRepository<InitiativeEntry>>().To<InitiativeEntryRepository>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<InitiativePresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }

        // Wrapper around system timer to pass it as ITimer implementer
        internal class WinFormTimer : System.Windows.Forms.Timer, ITimer { }
    }
}