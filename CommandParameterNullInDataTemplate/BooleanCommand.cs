using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;

namespace CommandParameterNullInDataTemplate
{
  public class BooleanCommand : MarkupExtension, ICommand
  {
    public event EventHandler CanExecuteChanged;
    public bool CanExecute(object parameter)
    {
      if (parameter is Boolean b)
      {
        return true;
      }

      return false;
    }
    public void Execute(object parameter)
    {
    }
    public override object ProvideValue(IServiceProvider serviceProvider)
      => this;
  }
}
