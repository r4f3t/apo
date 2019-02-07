namespace DBProcer
{
    interface IAdminUser : IUserType
    {
        bool askPermission();
    }

}
