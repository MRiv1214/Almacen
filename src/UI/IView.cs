using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UI;

public interface IView
{
    /// <summary>
    /// Returns selected option.
    /// If option is null or whitespace it goes back to previous view.
    /// </summary>
    public string GetOption();

    /// <summary>
    /// Performs option selected by <c>GetOption</c>.
    /// Results must be saved on <c>ViewManager.data</c> field.
    /// </summary>
    public void DoOption(string option);
}
