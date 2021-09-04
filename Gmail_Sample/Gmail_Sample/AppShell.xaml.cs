using Gmail_Sample.ViewModels;
using Gmail_Sample.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Gmail_Sample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
