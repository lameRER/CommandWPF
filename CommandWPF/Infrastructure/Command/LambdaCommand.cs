using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandWPF.Infrastructure.Command
{
    internal class LambdaCommand : Base.Command
    {
        private readonly Action<object?> _onExecute;
        private readonly Func<object?, bool>? _onCanExecute;

        public LambdaCommand(Action<object?> onExecute, Func<object?, bool>? onCanExecute = null)
        {
            _onExecute = onExecute;
            _onCanExecute = onCanExecute;
        }

        public override void Execute(object? parameter)
        {
            _onExecute(parameter);
        }

        public override bool CanExecute(object? parameter)
        {
            return base.CanExecute(parameter) && (_onCanExecute?.Invoke(parameter) ?? true);
        }
    }
}
