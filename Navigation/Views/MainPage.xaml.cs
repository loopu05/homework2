using Navigation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation.Views 
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainPage : BaseContentPage
    {
       
       
        public MainPage()
        {
            InitializeComponent();
            Title = "Page 1";
            BindingContext = new PageViewModel();
        }
        
        protected override void OnAppearing()
        {
            stackLabel.Text = base.GetNavigationMode().ToString();
            base.OnAppearing();
        }
            
        private async void GoToForward(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
