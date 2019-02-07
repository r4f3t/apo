using System;
namespace DBProcer
{
    class AdminUser : IAdminUser
    {
        UserModel userModel;
        public AdminUser(UserModel _userModel)
        {
            _userModel.AUTHORITY = 1;
            this.userModel = _userModel;
        }
        public bool askPermission()
        {
            return true;
        }

        public void doSometh()
        {
            Console.WriteLine((askPermission()) ? "İzin Var Admin Eklendi!!!" : "İzin Yok Erişim Reddedildi");
            Console.WriteLine(userModel.USerId.ToString());
            Console.WriteLine(userModel.UserName);
            Console.WriteLine(userModel.Name);
            Console.WriteLine(userModel.Adress);
        }
    }

}
