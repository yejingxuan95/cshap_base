using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Socket02_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Socket socket;
        private void button1_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(this.txtip.Text);
            IPEndPoint point = new IPEndPoint(ip,Convert.ToInt32(this.txtport.Text));
            socket.Connect(point);
            ShowMsg("连接成功");
        }

        private void ShowMsg(string s) {
            this.textrec.AppendText(s + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(this.textsend.Text);
            socket.Send(buffer);
        }
    }
}
