namespace DBProcer
{
    class UserModel
    {

        public int USerId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int AUTHORITY { get; set; }
        public UserModel() { }
        public UserModel(int _userId, string _userName, string _name, string _adress)
        {
            USerId = _userId;
            UserName = _userName;
            Name = _name;
            Adress = _adress;
        }
    }

}
