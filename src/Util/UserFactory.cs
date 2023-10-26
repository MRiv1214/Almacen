using Almacen.Models;

namespace Util.UserFactory;
// Implementation of IUserFactory
/*
    Create a user with IUserFactory.CreateUser(userType,username,password)  method

userType can be UserFactory.teacher, UserFactory.student, UserFactory.storekeeper, UserFactory.admin

    IUser user = IUserFactory.CreateUser(UserFactory.admin,user,pass);
*/

public interface IUserFactory
{
    IUser CreateUser(string userType, string username, string password);
    public const string teacher = "teacher", student = "student", storekeeper = "storekeeper", admin = "admin";
}
public class UserFactory : IUserFactory
{
    public const string teacher = "teacher", student = "student", storekeeper = "storekeeper", admin = "admin";
    
    public IUser CreateUser(string userType, string username, string password)
    {
        IUser? user = null;

        switch (userType.ToLower())
        {
            case teacher:
                user = new Teacher { Username = username, Password = password };
                break;
            case student:
                user = new Student { Username = username, Password = password };
                break;
            case storekeeper:
                user = new StoreKeeper { Username = username, Password = password };
                break;
            case admin:
                user = new Admin { Username = username, Password = password };
                break;
            default:
                throw new ArgumentException("Invalid user type");
        }

        return user;
    }
}

