using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation.Common
{
    interface IViewActionsHandler
    {
        void OnAppearing(NavigationMode navigationMode);
        void OnDisappearing();
        void OnResume();
    }
}
