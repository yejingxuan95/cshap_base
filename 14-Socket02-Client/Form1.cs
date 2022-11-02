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

namespace _14_Socket02_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private Socket socket;
        private void button1_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(this.txtip.Text);
            IPEndPoint point = new IPEndPoint(ip,Convert.ToInt32(this.txtport.Text));
            socket.Connect(point);
            ShowMsg("连接成功");
            Thread thread = new Thread(Receive);
            thread.IsBackground = true;
            thread.Start(socket);
        }

        private void ShowMsg(string s) {
            this.textrec.AppendText(s + "\r\n");
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(this.textsend.Text);
            socket.Send(buffer);
            
        }

        private void Receive(object inObject) {
            Socket socket = inObject as Socket;
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int r = socket.Receive(buffer);
                if (r == 0)
                {
                    break;
                }
                string s = Encoding.Default.GetString(buffer, 0, r);
                ShowMsg(socket.RemoteEndPoint.ToString() + ":" + s);
            }
            
        }
    }
}
