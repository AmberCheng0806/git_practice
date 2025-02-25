using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
            LoginService loginService = new LoginService();
            Console.WriteLine("登入結果:" + loginService.Login());
            Console.ReadKey();
        }

        static void Test()
        {
            Console.WriteLine("World");

        }


    }
}
