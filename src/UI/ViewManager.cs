using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI;

public class ViewManager
{
    public static Stack<IView> viewStack = new();
    public static object? data;

    public ViewManager(IView initialView)
    {
        Next(view: initialView);
    }

    public static void ExecuteView(IView view)
    {
        var option = view.GetOption();

        if (!string.IsNullOrEmpty(option)) {
            view.DoOption(option);
        } else {
            viewStack.Pop();
        }
    }

    public static void Run()
    {
        while (viewStack.Count != 0) {
            IView currentView = viewStack.Peek();
            ExecuteView(currentView);
        }
    }

    public static void Next(IView view)
    {
        viewStack.Push(view);
    }

    public static void Previous()
    {
        viewStack.Pop();
    }
}
