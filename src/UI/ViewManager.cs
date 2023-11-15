using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI;

public class ViewManager
{
    private Stack<View> viewStack = new();

    public void ShowView(View view)
    {
        viewStack.Push(view);
        RunCurrentView();
    }
    private void RunCurrentView()
    {
        View currentView = viewStack.Peek();
        //currentView.Show();
        /*var option = currentView.GetOption();
        if (option == 0)
        {
            viewStack.Pop();
            if (viewStack.Count > 0)
            {
                RunCurrentView();
            }
        }
        else
        {
            currentView.RunOption(option);
            RunCurrentView();
        }
        */
    }

}