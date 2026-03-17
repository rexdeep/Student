using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace StudentManagerApplication.ViewModel
{
    public class Command : ICommand
    {
        private Action<object> action;

        public Command(Action<object> actionMethod)
        {
            action = actionMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            action(parameter);
        }
    }
}