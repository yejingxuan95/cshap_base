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
                Thread thread = new Thread(SocketRecea);
                thread.IsBackground = true;
                thread.Start(socketClient);

            }
        }

        private void SocketRecea(object socketClient)
        {
            Socket socket = socketClient as Socket;
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024 * 2];
                int r = socket.Receive(buffer);
                if (r==0)
                {
                    break;
                }
                string s = Encoding.Default.GetString(buffer, 0, r);
                ShowMsg(socket.RemoteEndPoint.ToString() + ":" + s);
            }
            

        }

        private void ShowMsg(string msg) {
            this.textBox1.AppendText(msg + "\r\n");
        }
    }
}
