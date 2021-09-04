
using Gmail_Sample.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Gmail_Sample.Models;

namespace Gmail_Sample.ViewModels
{
    
    public class AboutViewModel : BaseViewModel
    {
        private Email _selectedEmail;

        public Email SelectedEmail
        {
            get
            {
                return _selectedEmail;
            }
            set
            {
                _selectedEmail = value;
                if (_selectedEmail != null)
                {
                    SelectedEmailCommand.Execute(_selectedEmail);
                }
            }
        }
        private ICommand SelectedEmailCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ObservableCollection<Email> Emails { get; } = new ObservableCollection<Email>()
        {
           
        };

        public AboutViewModel()
        {
            SelectedEmailCommand = new Command<Email>(OnEmailSelected);
            AddCommand = new Command(AddEmail);
            DeleteCommand = new Command<Email>(DeleteEmail);
        }

        private void DeleteEmail(Email email)
        {
            Emails.Remove(email);
        }

        private async void AddEmail()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddEmailPage(Emails));
        }

        private async void OnEmailSelected(Email email )
        {
            await App.Current.MainPage.Navigation.PushAsync(new EmailDetailPage(email));
        }

        
    }
}