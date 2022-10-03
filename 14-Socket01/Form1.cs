using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Socket01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            IPEndPoint point = new IPEndPoint(ip, 50000);
            socketWatch.Bind(point);
            ShowMsg("监听");
            socketWatch.Listen(10);
            Thread thread = new Thread(SocketListen);
            thread.IsBackground = true;
            thread.Start(socketWatch);
            
        }

        private void SocketListen(object socket) {
            Socket socketWatch = socket as Socket;
            while (true)
            {
                Socket socketClient = socketWatch.Accept();

                ShowMsg(socketClient.RemoteEndPoint.ToString() + "连接成功");
            }
        }

        private void ShowMsg(string msg) {
            this.textBox1.AppendText(msg + "\r\n");
        }
    }
}
