using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Test);
            thread.IsBackground = true;
            thread.Start();
        }
        private void Test() {
            for (int i = 0; i < 1000; i++)
            {
                this.textBox1.Text = ""+i;
            }
        
        }

        private bool runState = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!runState)
            {
                runState = true;
                this.button2.Text = "停止";
                Thread thread = new Thread(start);
                thread.IsBackground = true;
                thread.Start();
            }
            else {
                this.button2.Text = "开始";
                runState = false;
            }
        }
        private void start() {

            Random random = new Random();
            while (runState) {
                this.label1.Text = random.Next(0, 10).ToString();
                this.label2.Text = random.Next(0, 10).ToString();
                this.label3.Text = random.Next(0, 10).ToString();

            }

        }
    }
}
