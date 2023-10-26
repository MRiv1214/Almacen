namespace Almacen.Models;

public class Admin : IUser
{
    public string? Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool Authenticate(string username, string password) => Username == username && Password == password;
}