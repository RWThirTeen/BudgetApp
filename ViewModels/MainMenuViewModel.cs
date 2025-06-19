using BudgetApp.Infrastructure.Commands;
using BudgetApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.ViewModels
{
    internal class MainMenuViewModel : ViewModel
    {
        readonly MainWindowViewModel _mainWindowVM;







        #region Commands

        public Command OpenStatisticMenuCommand { get; }
        bool CanOpenStatisticMenuCommandExecute (object p) => true;
        void OnOpenStatisticMenuCommandExecuted (object p)
        {

        }

        public Command OpenIncomeMenuCommand { get; }
        bool CanOpenIncomeMenuCommandExecute(object p) => true;
        void OnOpenIncomeMenuCommandExecuted(object p)
        {

        }

        public Command OpenOutcomeMenuCommand { get; }
        bool CanOpenOutcomeMenuCommandExecute(object p) => true;
        void OnOpenOutcomeMenuCommandExecuted(object p)
        {

        }

        public Command OpenActivesMenuCommand { get; }
        bool CanOpenActivesMenuCommandExecute (object p) => true;
        void OnOpenActivesMenuCommandExecuted (object p)
        {

        }

        public Command OpenSettingsMenuCommand { get; }
        bool CanOpenSettingsMenuCommandExecute (object p) => true;
        void OnOpenSettingsMenuCommandExecuted (object p)
        {

        }

        public Command ExitApplicationCommand { get; }
        bool CanExitApplicationCommandExecute(object p) => true;
        void OnExitApplicationCommandExecuted(object p)
        {
            App.Current.Shutdown();
        }

        #endregion


        public MainMenuViewModel(MainWindowViewModel mainWindowVM)
        {
            _mainWindowVM = mainWindowVM;



            OpenStatisticMenuCommand = new LambdaCommand(OnOpenStatisticMenuCommandExecuted, CanOpenStatisticMenuCommandExecute);
            OpenIncomeMenuCommand = new LambdaCommand(OnOpenIncomeMenuCommandExecuted, CanOpenIncomeMenuCommandExecute);
            OpenOutcomeMenuCommand = new LambdaCommand(OnOpenOutcomeMenuCommandExecuted, CanOpenOutcomeMenuCommandExecute);
            OpenActivesMenuCommand = new LambdaCommand(OnOpenActivesMenuCommandExecuted, CanOpenActivesMenuCommandExecute);
            OpenSettingsMenuCommand = new LambdaCommand(OnOpenSettingsMenuCommandExecuted, CanOpenSettingsMenuCommandExecute);
            ExitApplicationCommand = new LambdaCommand(OnExitApplicationCommandExecuted, CanExitApplicationCommandExecute);
        }
    }
}
