using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HomeApp.Command
{
    internal class MainWindowViewModel: BaseViewModel
    {

        private readonly Validation _validation;
        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public ICommand AuthhCommand
        {
            get;
        }
        public MainWindowViewModel()
        {
            _validation = new Validation();
            AuthhCommand = new DelegateCommand(Auth);
        }
        public void Auth(object obj)
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            if (_validation.CheckingConditions(Login, Password))
            {
                MessageBox.Show("Вы успешно авторизовались", "Вход", MessageBoxButton.OK);
               
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует.\nПожалуйста, проверьте введенные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

    }
}
