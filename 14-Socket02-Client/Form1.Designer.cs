
namespace _14_Socket02_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textsend = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtport = new System.Windows.Forms.TextBox();
            this.textrec = new System.Windows.Forms.TextBox();
            this.butsendfile = new System.Windows.Forms.Button();
            this.butopenfile = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(32, 41);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(163, 21);
            this.txtip.TabIndex = 0;
            this.txtip.Text = "192.168.137.1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textsend
            // 
            this.textsend.Location = new System.Drawing.Point(32, 80);
            this.textsend.Multiline = true;
            this.textsend.Name = "textsend";
            this.textsend.Size = new System.Drawing.Size(571, 118);
            this.textsend.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "发送消息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(225, 41);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(100, 21);
            this.txtport.TabIndex = 4;
            this.txtport.Text = "50000";
            // 
            // textrec
            // 
            this.textrec.Location = new System.Drawing.Point(32, 233);
            this.textrec.Multiline = true;
            this.textrec.Name = "textrec";
            this.textrec.Size = new System.Drawing.Size(313, 118);
            this.textrec.TabIndex = 5;
            // 
            // butsendfile
            // 
            this.butsendfile.Location = new System.Drawing.Point(670, 328);
            this.butsendfile.Name = "butsendfile";
            this.butsendfile.Size = new System.Drawing.Size(75, 23);
            this.butsendfile.TabIndex = 9;
            this.butsendfile.Text = "发送文件";
            this.butsendfile.UseVisualStyleBackColor = true;
            // 
            // butopenfile
            // 
            this.butopenfile.Location = new System.Drawing.Point(670, 287);
            this.butopenfile.Name = "butopenfile";
            this.butopenfile.Size = new System.Drawing.Size(75, 23);
            this.butopenfile.TabIndex = 8;
            this.butopenfile.Text = "选择";
            this.butopenfile.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(392, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 21);
            this.textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butsendfile);
            this.Controls.Add(this.butopenfile);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textrec);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textsend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtip);
            this.Name = "Form1";
            this.Text = "客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textsend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox textrec;
        private System.Windows.Forms.Button butsendfile;
        private System.Windows.Forms.Button butopenfile;
        private System.Windows.Forms.TextBox textBox3;
    }
}

