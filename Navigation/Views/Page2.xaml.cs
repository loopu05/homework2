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
    public partial class Page2 :BaseContentPage
    {
  
        IReadOnlyList<Page> a;
        public Page2()
        {
            
            InitializeComponent();
            Title = "Page 2";
            BindingContext = new PageViewModel(); 
        }
        protected override void OnAppearing()
        {
            stackLabel.Text = base.GetNavigationMode().ToString();
            base.OnAppearing();
            
        }
      
        private  void GoToForward(object sender, EventArgs e)
        {
            Page3 page = new Page3();
            Navigation.PushAsync(page);
            
        }

        private  void GoToBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}