using Gmail_Sample.Models;
using Gmail_Sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gmail_Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailDetailPage : ContentPage
    {
        public EmailDetailPage(Email email)
        {
            InitializeComponent();
            BindingContext = new EmailDetailViewModel(email);
        }
    }
}