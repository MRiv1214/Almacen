// See https://aka.ms/new-console-template for more information
using UI.Login;
using UI.Menu;
using Almacen.Models;

IUser? user;
do
{
    user = Login.ConsoleLogin();
    if (user != null)
    {
        Menu.MainMenu(user);
    }
} while (true);