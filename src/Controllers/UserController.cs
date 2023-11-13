using Almacen.Models.AutoGen;
using Almacen.Repository;
using Almacen.Models.Dtos;

namespace Almacen.Controllers;

public class UserController
{
    private readonly IRepository<User>? userRepository;

    public UserController(IRepository<User>? userRepository)
    {
        this.userRepository = userRepository;
    }

    public long CreateUser(UserDto userDto)
    {
        var user = new User
        {
            Password = userDto.Password,
            Name = userDto.Name,
            LastName = userDto.LastName
        };
        userRepository?.Create(user);
        return user.UserId;
    }
    public IEnumerable<UserDto> GetAllUsers()
    {
        var users = userRepository?.GetAll();
        if (users == null)
        {
            return new List<UserDto>();
        }
        return users.Select(user => new UserDto
        {
            UserId = user.UserId,
            Password = user.Password!,
            Name = user.Name!,
            LastName = user.LastName!
        });
    }
    public UserDto GetUserById(long id)
    {
        var user = (userRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new UserDto
        {
            UserId = user.UserId,
            Password = user.Password!,
            Name = user.Name!,
            LastName = user.LastName!
        };
    }
    public UserDto? GetUserByCredentials(byte[] password, string name)
    {
        var user = userRepository?.GetSingleBy(x => x.Password.SequenceEqual(password) && x.Name == name);
        if (user == null)
        {
            return null;
        }
        return new UserDto
        {
            UserId = user.UserId,
            Password = user.Password!,
            Name = user.Name!,
            LastName = user.LastName!
        };
    }
    public void RemoveUser(long id)
    {
        var user = (userRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        userRepository?.Remove(user);
    }

    public void UpdateUser(UserDto userDto)
    {
        var user = userRepository?.GetById(userDto.UserId ?? throw new ArgumentException("Invalid id"))?? throw new ArgumentException("Invalid id");
        user.Name = userDto.Name;
        user.LastName = userDto.LastName;
        userRepository?.Update(user);
    }
}