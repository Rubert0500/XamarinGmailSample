using Gmail_Sample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Gmail_Sample.ViewModels
{
    public class AddEmailViewModel : BaseViewModel
    {
        public ICommand AddEmailCommand { get; }

        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string ComposeEmail { get; set; }
        public DateTime Date { get; }

        public AddEmailViewModel(ObservableCollection<Email> emails)
        {
            _emails = emails;

            AddEmailCommand = new Command(async () => {

                emails.Add(new Email(To, From, Subject, ComposeEmail ));
                await App.Current.MainPage.Navigation.PopAsync();
            
            });
           
        }

       private ObservableCollection<Email> _emails;
    }
}
