using RegistrationTest.Command;
using RegistrationTest.Core;
using System.Windows.Input;

namespace RegistrationTest.ViewModel
{
    class RegistrationViewModel : BaseViewModel
    {
        private string _login;
        private string _password;

        public string Login { get => _login; set => SetProperty(ref _login, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }

        public ICommand AddNewUserCommand { get; private set; }

        public RegistrationViewModel() => AddNewUserCommand = new RelayCommand(AddNewUser);

        private void AddNewUser(object obj) => DbManneger.AddUser(_login, _password);

    }
}
