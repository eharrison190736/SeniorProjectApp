using SeniorProjectApp.Models;
using SeniorProjectApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace SeniorProjectApp.ViewModels
{
    public class TheTestModel : BaseViewModel
    {
        private double number;
        private string text;
        private string description;
        public Command TestCommand { get; }

        public TheTestModel()
        {
            SaveCommand = new Command(OnSave);
            TestCommand = new Command(TheTestClicked);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private async void TheTestClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
        public double Count
        {
            get => Count;
            set => SetProperty(ref number, (Count + 1));
        }
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Command SaveCommand { get; }
        private async void OnSave()
        {
            Item newAns = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Description = Description,
                     Count = Count + 1
            };
            await DataStore.AddItemAsync(newAns);
        }
    }
}