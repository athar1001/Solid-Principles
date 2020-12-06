using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility
{
    class User
    {
        private readonly string _username;
        private readonly string _email;
        private readonly string _password;

        public User(string username, string email, string password)
        {
            _username = username;
            _email = email;
            _password = password;

        }
    }
}
