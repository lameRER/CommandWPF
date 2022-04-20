using System;
using System.Windows.Input;

namespace CommandWPF.Infrastructure.Command.Base
{
    internal abstract class Command : ICommand
    {
        public virtual bool CanExecute(object? parameter) => true;

        public abstract void Execute(object? parameter);

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
