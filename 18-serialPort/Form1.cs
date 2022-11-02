using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_serialPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new Action(()=> {
                this.textBox1.Text = this.serialPort1.ReadExisting();
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.serialPort1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.serialPort1.Write(this.textBox2.Text);
        }
    }
}
