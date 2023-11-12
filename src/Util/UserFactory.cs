

namespace Util.UserFactory;
// Implementation of IUserFactory
/*
    Create a user with IUserFactory.CreateUser(userType)  method

userType can be UserFactory.teacher, UserFactory.student, UserFactory.storekeeper, UserFactory.admin

*/

public interface IUserFactory
{
    void CreateUser(string userType, string username, string password);
    public const string teacher = "teacher", student = "student", storekeeper = "storekeeper", admin = "admin";
}
public class UserFactory : IUserFactory
{
    public const string teacher = "teacher", student = "student", storekeeper = "storekeeper", admin = "admin";
    
    public void CreateUser(string userType, string username, string password)
    {

        switch (userType.ToLower())
        {
            case teacher:

                break;
            case student:
                
                break;
            case storekeeper:
                
                break;
            case admin:
                
                break;
            default:
                throw new ArgumentException("Invalid user type");
        }

    }
}

