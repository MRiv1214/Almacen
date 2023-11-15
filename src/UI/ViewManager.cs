using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI;

public class ViewManager
{
    public static Stack<IView> viewStack = new();

    public ViewManager(IView initialView)
    {
        Next(view: initialView);
    }

    public static void Run()
    {
        while (viewStack.Count() != 0)
        {
            IView currentView = viewStack.Peek();
            //currentView.Show();
            var option = currentView.GetOption();
            if (!string.IsNullOrEmpty(option))
            {
                currentView.DoOption(option);
            }
            else
            {
                viewStack.Pop();
            }
        }
    }

    public static void Next(IView view)
    {
        viewStack.Push(view);
    }

}