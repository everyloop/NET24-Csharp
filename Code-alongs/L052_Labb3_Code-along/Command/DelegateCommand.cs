using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace L052_Labb3_Code_along.Command
{
    internal class DelegateCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object?, bool> canExecute;

        public event EventHandler? CanExecuteChanged;

        public DelegateCommand(Action<object> execute, Func<object?, bool> canExecute = null)
        {
            ArgumentNullException.ThrowIfNull(execute);
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object? parameter) => canExecute is null ? true : canExecute(parameter);
        
        public void Execute(object? parameter) => execute(parameter);

    }
}
