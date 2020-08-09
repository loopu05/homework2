using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Navigation.Models
{
    public class PageViewModel:BaseViewModel
    {
        public override void OnAppearing(NavigationMode navigationMode)
        {
            base.OnAppearing(navigationMode);

            if (navigationMode == NavigationMode.New)
            {
                IsVisibleSpinner = true;
            }

            if (navigationMode == NavigationMode.Back)
            {
                IsVisibleSpinner = false;
            }


        }
        private bool _isVisibleSpinner;
        public bool IsVisibleSpinner
        {
            get => _isVisibleSpinner;
            set => SetProperty(ref _isVisibleSpinner, value);
        }

        public ICommand ShowSpinnerCommand { get; }
        private void OnShowSpinnerCommand(object obj)
        {
            IsVisibleSpinner = true;
        }
        public override void OnResume()
        {
            base.OnResume();
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
