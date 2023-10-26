using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace Almacen.Models;

public class Teacher : IUser
{
    public string? Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool Authenticate(string username, string password) => this.Username == username && this.Password == password;
}
