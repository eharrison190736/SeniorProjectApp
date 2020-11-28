using System.ComponentModel;
using Xamarin.Forms;
using SeniorProjectApp.ViewModels;

namespace SeniorProjectApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}