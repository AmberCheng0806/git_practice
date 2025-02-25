using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class LoginModel
    {
        public string Name { get; set; }
        public String Account { get; set; }
        public String Password { get; set; }

        private bool CheckPasswordIsValid(string password)
        {
            return true;
        }
    }
}
