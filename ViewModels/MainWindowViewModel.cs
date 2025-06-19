using BudgetApp.Infrastructure.Commands;
using BudgetApp.ViewModels.Base;
using BudgetApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BudgetApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region CurrentView

        ViewModel _currentViewModel;
        public ViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set => Set(ref _currentViewModel, value);
        }

        Dictionary<string, ViewModel> _viewModelDictionary;

        public void SwitchCurrentView(string name)
        {
            if (_viewModelDictionary == null) return; // сообщение об ошибке

            if (!_viewModelDictionary.ContainsKey(name)) CreateNewView(name);

            CurrentViewModel = _viewModelDictionary[name];

        }

        void CreateNewView(string name)
        {
            switch(name)
            {
                case "MainMenu":
                    _viewModelDictionary.Add(name, new MainMenuViewModel(this));
                    break;


                default: return; // error
            }
        }

        #endregion



        #region Commands


        

        #endregion



        public MainWindowViewModel()
        {
            _viewModelDictionary = new Dictionary<string, ViewModel>();


            

            SwitchCurrentView("MainMenu");
        }
    }
}
