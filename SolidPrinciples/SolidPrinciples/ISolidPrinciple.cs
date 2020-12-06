using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    interface IUserAuthentication
    {
        bool Signup(string username, string password, string email);
        bool Signin(string username, string password);
       
        
    }

    interface IErrorLogger
    {
        void LogError(string error);
    }

    interface IEmailSender
    {
        bool SendEmail(string payload);
    }
}
