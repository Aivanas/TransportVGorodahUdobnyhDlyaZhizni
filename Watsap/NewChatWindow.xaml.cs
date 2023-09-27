using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Watsap
{
    /// <summary>
    /// Логика взаимодействия для NewChatWindow.xaml
    /// </summary>
    public partial class NewChatWindow : Window
    {        
        private TcpClient _tcpClient;
        private TcpServer _tcpServer;

        public NewChatWindow()
        {
            InitializeComponent();
            
            
        }
        public NewChatWindow(string ip, string name) : this()
        {
            
            var serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _tcpServer = new TcpServer();
            var serverTask = _tcpServer.StartServerAsync(serverSocket, messagesLbx, this.usersLbx);
            var clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _tcpClient = new TcpClient(name, clientSocket, ip, messagesLbx, this.usersLbx);
            _tcpClient.ReceiveMessage(_tcpClient.IsWorking.Token);
            _tcpClient.SendMessage($"{name} подключился... /connect_username= {name}");

        }

        private async void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            if (messageTb.Text != null)      
                await sendMsg(messageTb.Text); 
                   
            Thread.Sleep(5);
        }
        private async Task sendMsg(string message)
        {
            await _tcpClient.SendMessage(message);
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            _tcpClient.Dispose();
            this.Close();
        }
    }
}
