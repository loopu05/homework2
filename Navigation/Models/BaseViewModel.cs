using Navigation.Common;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Navigation
{
   public  class BaseViewModel : BindableBase, IViewActionsHandler
    {
        private ICommand _onAppearingCommand;
        public ICommand OnAppearingCommand
        {
            get => _onAppearingCommand;
            set => SetProperty(ref _onAppearingCommand, value);
        }

        private ICommand _onDisappearingCommand;
        public ICommand OnDisappearingCommand
        {
            get => _onDisappearingCommand;
            set => SetProperty(ref _onDisappearingCommand, value);
        }

        public virtual void OnAppearing(NavigationMode navigationMode)
        {
            OnAppearingCommand?.Execute(null);
        }

        public virtual void OnDisappearing()
        {
            OnDisappearingCommand?.Execute(null);
        }

        public virtual void OnResume()
        {
        }
    }
}
