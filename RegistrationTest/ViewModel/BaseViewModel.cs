using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RegistrationTest.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public virtual void SetProperty<T>([Required] ref T destination, T value, [CallerMemberName] string prop = null)
        {
            destination = value;
            OnPropertyChanged(prop);
        }
    }
}
