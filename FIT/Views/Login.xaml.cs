using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FIT.Views
{ 
   

        public partial class Login : Window
        {
            public Login()
            {
                InitializeComponent();
            }

            private void LoginButton_Click(object sender, RoutedEventArgs e)
            {
                string login = LoginTextBox.Text;
                string password = PasswordBox.Password;

                if (login == "admin" && password == "1234")
                {
                    MessageBox.Show("Успешный вход!");
                }
                else
                {
                    ErrorText.Text = "Неверный логин или пароль";
                }
            }
        }
}
