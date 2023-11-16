using Almacen.Models.AutoGen;

namespace Almacen.Helpers;

public enum UserType
{
    Admin = 1,
    StoreKeeper = 2,
    Teacher = 3,
    Student = 4,
    
}

public class UserTypeHelper
{
    public static UserType GetUserType(User user)
    {
        if (user.Student != null) {
            return UserType.Student;
        }

        return (UserType) user.Employee!.UserType!;

    }
}