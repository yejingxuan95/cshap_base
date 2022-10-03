using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_musicplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> fileList = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "请选择要加载的文件";
            fileDialog.InitialDirectory = @"C:\Users\11432\Desktop\music";
            fileDialog.Filter = "音乐文件|*.wav|所有文件|*.*";
            fileDialog.Multiselect = true;
            fileDialog.ShowDialog();
            string[] files = fileDialog.FileNames;
            
            for (int i = 0; i < files.Length; i++)
            {
                
                this.listBox1.Items.Add(Path.GetFileName(files[i]));
                fileList.Add(files[i]);
            }
        }
        SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            
            sp.SoundLocation = fileList[this.listBox1.SelectedIndex];
            sp.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index++;
            
            if (index == listBox1.Items.Count) {
                index = 0;
            }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = fileList[index];
            sp.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count-1;
            }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = fileList[index];
            sp.Play();
        }
    }
}
