// Purpose: Model for StoreKeeper.
namespace Almacen.Models;

public class StoreKeeper : IUser
{
    public string? Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool Authenticate(string username, string password) => this.Username == username && this.Password == password;
    public StoreKeeper()
    {
        Id = null;
        Username = null;
        Password = null;
    }
}