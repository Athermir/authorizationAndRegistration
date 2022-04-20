using RegistrationTest.Command;
using RegistrationTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationTest.ViewModel
{
    class AuthorizationViewModel : BaseViewModel
    {
        private string _login;
        private string _password;

        public string Login { get => _login; set => SetProperty(ref _login, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }
        public ICommand AuthorizationUserCommand { get; private set; }
        public ICommand GoRegistrationWindowCommand { get; private set; }

        public AuthorizationViewModel() => ( AuthorizationUserCommand, GoRegistrationWindowCommand) =
            (new RelayCommand(AuthorizationUser), new RelayCommand(GoRegistrationWindow));
        private void AuthorizationUser(object obj) => DbManneger.UserAuthorization(_login, _password);

        private void GoRegistrationWindow(object obj)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }
    }
}
