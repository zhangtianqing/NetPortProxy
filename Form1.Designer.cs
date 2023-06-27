namespace NetPortProxy
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_local_ip = new System.Windows.Forms.TextBox();
            this.textBox_local_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_remote_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_remote_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox_AutoStart = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_state = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本地监听IP";
            // 
            // textBox_local_ip
            // 
            this.textBox_local_ip.Location = new System.Drawing.Point(95, 10);
            this.textBox_local_ip.Name = "textBox_local_ip";
            this.textBox_local_ip.Size = new System.Drawing.Size(119, 21);
            this.textBox_local_ip.TabIndex = 1;
            // 
            // textBox_local_port
            // 
            this.textBox_local_port.Location = new System.Drawing.Point(95, 36);
            this.textBox_local_port.Name = "textBox_local_port";
            this.textBox_local_port.Size = new System.Drawing.Size(119, 21);
            this.textBox_local_port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "本地监听端口";
            // 
            // textBox_remote_ip
            // 
            this.textBox_remote_ip.Location = new System.Drawing.Point(95, 63);
            this.textBox_remote_ip.Name = "textBox_remote_ip";
            this.textBox_remote_ip.Size = new System.Drawing.Size(119, 21);
            this.textBox_remote_ip.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "远程接收IP";
            // 
            // textBox_remote_port
            // 
            this.textBox_remote_port.Location = new System.Drawing.Point(95, 90);
            this.textBox_remote_port.Name = "textBox_remote_port";
            this.textBox_remote_port.Size = new System.Drawing.Size(119, 21);
            this.textBox_remote_port.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "远程接收端口";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "协议";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.comboBox1.Location = new System.Drawing.Point(95, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // checkBox_AutoStart
            // 
            this.checkBox_AutoStart.AutoSize = true;
            this.checkBox_AutoStart.Location = new System.Drawing.Point(95, 146);
            this.checkBox_AutoStart.Name = "checkBox_AutoStart";
            this.checkBox_AutoStart.Size = new System.Drawing.Size(96, 16);
            this.checkBox_AutoStart.TabIndex = 11;
            this.checkBox_AutoStart.Text = "自动启动服务";
            this.checkBox_AutoStart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "读取配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadConfig);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "保存配置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveConfig);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "开始服务";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.StartServer);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(139, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "停止服务";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.StopServer);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(448, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "状态";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "出品：";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "Github:zhangtianqing";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_state});
            this.statusStrip2.Location = new System.Drawing.Point(0, 248);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(448, 22);
            this.statusStrip2.TabIndex = 17;
            this.statusStrip2.Text = "提示：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel2.Text = "状态：";
            // 
            // toolStripStatusLabel_state
            // 
            this.toolStripStatusLabel_state.Name = "toolStripStatusLabel_state";
            this.toolStripStatusLabel_state.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel_state.Text = "未启动";
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(221, 14);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Log.Size = new System.Drawing.Size(215, 230);
            this.textBox_Log.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 292);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_AutoStart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_remote_port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_remote_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_local_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_local_ip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP&UDP转发工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_local_ip;
        private System.Windows.Forms.TextBox textBox_local_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_remote_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_remote_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox_AutoStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_state;
        private System.Windows.Forms.TextBox textBox_Log;
    }
}

