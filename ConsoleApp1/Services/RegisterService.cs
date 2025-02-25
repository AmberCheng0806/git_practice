using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class RegisterService
    {
        public bool UserRegist(RegisterModel model)
        {
            UserModel userModel = new UserModel();
            userModel.Account = model.Account;
            userModel.Password = model.Password;
            return true;
        }
    }
}