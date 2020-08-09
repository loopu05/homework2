using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation
{
    public class Page3 : ContentPage
    {
        Label stackLabel; 
        IReadOnlyList<Page> a;
        public Page3()
        {
            Title = "Page 3";
            Button backBtn = new Button { Text = "Previous page" };
            backBtn.Clicked += GoToBack;

            stackLabel = new Label();
            Content = new StackLayout { Children = { backBtn, stackLabel } };
        }
        protected internal void DisplayStack()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            stackLabel.Text = "";
            a = navPage.Navigation.NavigationStack;
            stackLabel.Text = a[0].BindingContext.ToString();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            stackLabel.Text = "";
            a = navPage.Navigation.NavigationStack;
            stackLabel.Text = a[0].BindingContext.ToString();
        }        
        private async void GoToBack(object sender, EventArgs e)
        {
            a[0].BindingContext = NavigationMode.Back;
            await Navigation.PopAsync();
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;           
        }
    }
}
