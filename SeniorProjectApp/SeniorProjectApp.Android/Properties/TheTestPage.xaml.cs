using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeniorProjectApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeniorProjectApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheTestPage : ContentPage
    {
        public TheTestPage(object MyBindingObject )
        {
         
            this.BindingContext = MyBindingObject;
        }
    }
}