using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommandWPF.ViewModel.Base
{
    internal class ViewModel : INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler? PropertyChanging;

        protected virtual void OnPropertyChanging([CallerMemberName] string? propertyName = null)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual bool Set<T>(ref T fiend, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(fiend, value)) return false;
            fiend = value;
            OnPropertyChanging();
            return true;
        }
    }
}
