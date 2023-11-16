using System.Runtime.Serialization;
using Almacen.Helpers;
using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;

namespace Almacen.Controllers;

public class UserController
{
    AlmacenContext db = AlmacenContext.GetInstance();

    public (long, string?) CreateUser(UserDto userDto)
    {
        string message;
        var user = new User
        {
            Password = userDto.Password,
            Name = userDto.Name,
            LastName = userDto.LastName
        };
        //Check if user already exists
        if (db.Users.Any(x => x.Name == user.Name)) {
            message = "User already exists";
            return (0, message);
        } else {
            _ = db.Users.Add(user);
            int rows = db.SaveChanges();
            if (rows == 0) {
                message = "Error creating user";
                return (0, message);
            }
            return (user.UserId, null);
        }
    }

    // public IEnumerable<UserDto> GetAllUsers()
    // {
    //     var users = userRepository?.GetAll();
    //     if (users == null) {
    //         return new List<UserDto>();
    //     }
    //     return users.Select(user => new UserDto
    //     {
    //         UserId = user.UserId,
    //         Password = user.Password!,
    //         Name = user.Name!,
    //         LastName = user.LastName!
    //     });
    // }
    // public UserDto? GetUserById(long id)
    // {
    //     var user = userRepository?.GetById(id);
    //     if (user == null) return null;
    //     return new UserDto
    //     {
    //         UserId = user.UserId,
    //         Password = user.Password!,
    //         Name = user.Name!,
    //         LastName = user.LastName!
    //     };
    // }
    // public User? GetUserByName(string name)
    // {
    //     var user = userRepository?.GetSingleBy(x => x.Name == name);
    //     if (user == null) {
    //         return null;
    //     }
    //     return new User
    //     {
    //         UserId = user.UserId,
    //         Password = user.Password!,
    //         Name = user.Name!,
    //         LastName = user.LastName!
    //     };
    // }
    // public bool RemoveUser(long id)
    // {
    //     var user = userRepository?.GetById(id);
    //     if (user is null) return false;
    //     userRepository?.Remove(user);
    //     return true;
    // }
    //
    // public void UpdateUser(UserDto userDto)
    // {
    //     var user = userRepository?.GetById(userDto.UserId ?? throw new ArgumentException("Invalid id")) ?? throw new ArgumentException("Invalid id");
    //     user.Name = userDto.Name;
    //     user.LastName = userDto.LastName;
    //     userRepository?.Update(user);
    // }
    //
    // public bool UserExists(string name)
    // {
    //     var user = userRepository?.GetSingleBy(x => x.Name == name);
    //     if (user == null) {
    //         return false;
    //     }
    //     return true;
    // }

}
