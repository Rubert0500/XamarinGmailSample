using Gmail_Sample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gmail_Sample.ViewModels
{
    public class EmailDetailViewModel : BaseViewModel
    {
        public Email SelectedEmail { get; set; }
        public EmailDetailViewModel(Email email)
        {
            SelectedEmail = email;
        }
    }
}
