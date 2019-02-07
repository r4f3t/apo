namespace DBProcer
{
    class USERAdd
    {
        IUserType userType;
        public USERAdd(IUserType _userType)
        {
            userType = _userType;
        }
        public void writeToDb()
        {
            userType.doSometh();
        }

    }

}
