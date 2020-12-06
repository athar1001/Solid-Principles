using SolidPrinciples.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
System.ComponentModel.DataAnnotations;

namespace SolidPrinciples.S
{
    class Userinfo
    {
        public void UserRegistration(string username, string password, string email)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Not  a valid email");
            var user = new User(username, email, password);

            SendEmail(user);
        }

        public void Signin(string username, string password)
        {
            Console.WriteLine("Login Successfull");
        }

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
