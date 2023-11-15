using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Menu;

namespace Almacen.Helpers;
public class MenuManager
{
    private Stack<Menu> menuStack = new();

    public void ShowMenu(Menu menu)
    {
        menuStack.Push(menu);
        RunCurrentMenu();
    }
    private void RunCurrentMenu()
    {
        Menu currentMenu = menuStack.Peek();
        //currentMenu.Show();
        /*var option = currentMenu.GetOption();
        if (option == 0)
        {
            menuStack.Pop();
            if (menuStack.Count > 0)
            {
                RunCurrentMenu();
            }
        }
        else
        {
            currentMenu.RunOption(option);
            RunCurrentMenu();
        }
        */
    }
}