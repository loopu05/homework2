using Navigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : BaseContentPage
    {
       
        public Page3()
        {
            InitializeComponent();
            Title = "Page 3";            
            BindingContext = new PageViewModel();
        }
       
        protected override void OnAppearing()
        {
            stackLabel.Text = base.GetNavigationMode().ToString();
            base.OnAppearing();           
        }

        private  void GoToBack(object sender, EventArgs e)
        {
             Navigation.PopAsync();
        }
    }
}