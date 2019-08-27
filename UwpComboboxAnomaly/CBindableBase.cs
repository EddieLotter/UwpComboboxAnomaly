using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//see: https://github.com/Microsoft/Windows-task-snippets/blob/master/tasks/Data-binding-change-notification.md
namespace UwpComboboxAnomaly
{
    public abstract class CBindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value,
            [CallerMemberName] String propertyName = null)
        {
            if (object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
