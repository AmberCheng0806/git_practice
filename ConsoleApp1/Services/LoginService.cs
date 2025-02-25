using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class LoginService
    {
        LoginModel loginModel = new LoginModel();
        public bool Login()
        {
            if (loginModel.CheckPasswordIsValid() && loginModel.CheckAccountIsValid())
            {
                return true;
            }
            return false;
        }
    }
}
