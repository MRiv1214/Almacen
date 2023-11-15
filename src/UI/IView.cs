using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UI;

public interface IView
{
    public string GetOption();
    public void DoOption(string option);

}