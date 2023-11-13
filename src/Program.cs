// See https://aka.ms/new-console-template for more information
using Almacen.Models.AutoGen;
using UI.Login;
using UI.Menu;
User? user;
do
{
    user = Login.ConsoleLogin();
    
} while (user == null);

Menu.MainMenu(user);