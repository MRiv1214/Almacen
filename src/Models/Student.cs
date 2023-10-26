// Purpose: Model for Student users.
namespace Almacen.Models;

public class Student : IUser
{
    public string? Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool Authenticate(string username, string password) => this.Username == username && this.Password == password;
}