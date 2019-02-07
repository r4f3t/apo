using System;
namespace DBProcer
{
    class NormalUser : INormalUser
    {
        UserModel userModel;
        public NormalUser(UserModel _userModel)
        {
            _userModel.AUTHORITY = 2;
            userModel = _userModel;
        }

        public bool askIdentity()
        {
            return true;
        }

        public void doSometh()
        {
            if (askIdentity())
            {
                Console.WriteLine(userModel.USerId.ToString());
                Console.WriteLine(userModel.UserName);
                Console.WriteLine(userModel.Name);
                Console.WriteLine(userModel.Adress);
            }
            else
            {
                Console.WriteLine("Kimlik Yok Eklenemedi!!");
            }
        }
    }

}
