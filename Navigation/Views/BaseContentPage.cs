using Navigation.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation
{
    public class BaseContentPage: ContentPage
    {
        private IViewActionsHandler _actionsHandler;
        private object _object;
        private bool _fromBackground;
        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            _actionsHandler = BindingContext as IViewActionsHandler;
            if (_actionsHandler != null)
            {
                if (_fromBackground)
                {
                    _actionsHandler.OnResume();
                    return;
                }
                
                _actionsHandler.OnAppearing(GetNavigationMode());
                _object = new object();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (BindingContext == null)
            {
                _actionsHandler?.OnDisappearing();
                return;
            }
            _actionsHandler = BindingContext as IViewActionsHandler;
            if (_actionsHandler != null)
            {
                _actionsHandler.OnDisappearing();
            }

            _fromBackground = false;
        }

        public NavigationMode GetNavigationMode()
        {
            if (_object == null)
                return NavigationMode.New;

            return NavigationMode.Back;
        }

        private void OnBackgroundListener()
        {
            _fromBackground = true;
        }
    }
}
