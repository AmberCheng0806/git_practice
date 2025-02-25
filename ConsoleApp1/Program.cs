using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎使用 [XXX 註冊系統]！");
            Console.WriteLine("請依照指示完成註冊，讓我們開始吧！");

            Console.WriteLine("請輸入您的姓名：");
            string userName = Console.ReadLine();

            Console.WriteLine("接下來，請輸入您的帳號：");
            string account = Console.ReadLine();

            Console.WriteLine("請設置一個安全的密碼：");
            string password = Console.ReadLine();

            Console.WriteLine("最後，請輸入您的聯絡地址，讓我們方便與您保持聯繫：");
            string address = Console.ReadLine();

            RegisterModel user = new RegisterModel(userName, account, password, address);
            RegisterService service = new RegisterService();

            if (service.UserRegist(user))
            {
                Console.WriteLine("恭喜您，註冊成功！歡迎加入我們的大家庭！");
            }
            else
            {
                Console.WriteLine("很抱歉，註冊失敗了。請稍後再試，或聯繫我們的客服團隊以獲取協助。");
            }

            Console.WriteLine("感謝您使用 [XXX 註冊系統]，祝您有美好的一天！");
            Console.WriteLine("HELLO");
            LoginService loginService = new LoginService();
            Console.WriteLine("登入結果:" + loginService.Login());
            Console.ReadKey();
        }

    }
}
