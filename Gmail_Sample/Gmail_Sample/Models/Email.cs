using System;
using System.Collections.Generic;
using System.Text;

namespace Gmail_Sample.Models
{
    public class Email
    {
        public Email(string to, string from, string subject, string composeEmail)
        {
            To = to;
            From = from;
            Subject = subject;
            ComposeEmail = composeEmail;
            Date = DateTime.UtcNow;
        }

        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string ComposeEmail { get; set; }
        public DateTime Date { get; set; }
    }
}
