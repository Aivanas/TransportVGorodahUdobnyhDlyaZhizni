using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Watsap
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NewChatWindow _newChat;
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Для супер кайфа установите набор шрифтов из папки проекта");
        }

        private void newChatBtn_Click(object sender, RoutedEventArgs e)
        {
            Validation();  
        }

        private void oldChatBtn_Click(object sender, RoutedEventArgs e)
        {
            Validation();
        }
        private static bool ValidateIpAddress(string ipAddress)
        {
            IPAddress address;
            bool isValidIpAddress = IPAddress.TryParse(ipAddress, out address);

            return isValidIpAddress;
        }
        private static bool ValidateUsername(string username)
        {
            string pattern = @"^[a-zA-Z0-9_\-]+$";
            bool isValidUsername = Regex.IsMatch(username, pattern);

            return isValidUsername;
        }
        private void Validation()
        {
            if (ValidateIpAddress(ipTb.Text) == true && ValidateUsername(userNameTb.Text) == true)
            {
                _newChat = new NewChatWindow(ipTb.Text, userNameTb.Text);
                _newChat.Show();
            }
            else
            {
                MessageBox.Show("Неправильно введено ip или имя пользователя!");
            }
        }
    }
}
 