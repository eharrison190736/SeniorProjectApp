using SeniorProjectApp.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SeniorProjectApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            openTest = new Command(Open);
        }
        private async void Open()
            {
                // This will pop the current page off the navigation stack
                await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
            }

        private readonly Command openTest;

        public Command GetOpenTest()
        {
            return openTest;
        }
    }
}