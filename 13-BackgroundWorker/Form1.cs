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

namespace _13_BackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            int count = Convert.ToInt32(this.textBox1.Text.ToString().Trim());
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = this.progressBar1.Minimum;
            this.backgroundWorker1.RunWorkerAsync(count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = Convert.ToInt32(e.Argument);
            int sum = 0;
            double countIndex = count / 100;
            for (int i = 1; i <= count; i++)
            {
                Thread.Sleep(10);
                sum += i;
                double countD = count;
                double iD = i;
                Console.WriteLine(iD / countD);
                double a = (double)(iD / countD) * 100;
                Console.WriteLine(a);
                this.label3.Text = Convert.ToString(Convert.ToInt32(a));

                this.backgroundWorker1.ReportProgress(Convert.ToInt32(a));
                if (this.backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                this.label1.Text = Convert.ToString(sum);
            }

            e.Result = sum;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.label2.Text = Convert.ToString(e.ProgressPercentage) + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.button1.Enabled = true;
            if (e.Cancelled) {
                MessageBox.Show("用户取消了操作");
            }
            else
            {
                //MessageBox.Show("操作完成，"+Convert.ToString(e.Result));
            }
        }
    }

    
}
