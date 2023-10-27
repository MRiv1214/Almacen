using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen.Helpers;

public class SHA256Password
{
    public static byte[] Encrypt(string password)
    {
        using (var sha256 = System.Security.Cryptography.SHA256.Create())
        {
            return sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
    public static bool Compare(byte[] password, byte[] passwordHash)
    {
        return password.SequenceEqual(passwordHash);
    }
}