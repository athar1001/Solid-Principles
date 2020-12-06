using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace SolidPrinciples.SingleResponsibility
{
    class UserInfo
    {
        public void UserRegistration(string username, string password, string email)
        {
            var emailservice = new EmailService();
            if (!emailservice.ValidateEmail(email))
                throw new ValidationException("Not  a valid email");
            var user = new User(username, email, password);

            emailservice.SendEmail(user);
        }

        public void Signin(string username, string password)
        {
            Console.WriteLine("Login Successfull");
        }
    }
}
