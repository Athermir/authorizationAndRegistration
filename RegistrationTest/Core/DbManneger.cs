using RegistrationTest.Model.Entities;
using RegistrationTest.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RegistrationTest.Core
{
    public static class DbManneger
    {
        public static void AddUser(string login, string password)
        {
            try
            {
                using (var context = new RegistrationTestEntitie())
                {
                    context.User.Add(new User(login, password));
                    context.SaveChanges();
                    MessageBox.Show("Пользователь добавлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public static void UserAuthorization(string log, string pas)
        {
            try
            {
                using (var context = new RegistrationTestEntitie())
                {
                    var user = context.User.FirstOrDefault(u => u.Login.Equals(log) & u.Password.Equals(pas));

                    if (user != null)
                    {
                        MessageBox.Show("Вход выполнен");
                        MenuWindow menuWindow = new MenuWindow();
                        menuWindow.Show();
                    }
                    else MessageBox.Show("Такого пользователя не существует");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
