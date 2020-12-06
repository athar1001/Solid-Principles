using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility
{
    class EmailService
    {
        public  bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(User message)
        {
            Console.WriteLine("Message Sent Successfully");
        }
    }
}
