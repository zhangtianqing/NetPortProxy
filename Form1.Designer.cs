namespace NetPortProxy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_local_ip = new TextBox();
            textBox_local_port = new TextBox();
            label2 = new Label();
            textBox_remote_ip = new TextBox();
            label3 = new Label();
            textBox_remote_port = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            checkBox_AutoStart = new CheckBox();
            statusStrip2 = new StatusStrip();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            statusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "本地监听IP";
            // 
            // textBox_local_ip
            // 
            textBox_local_ip.Location = new Point(91, 6);
            textBox_local_ip.Name = "textBox_local_ip";
            textBox_local_ip.Size = new Size(152, 23);
            textBox_local_ip.TabIndex = 1;
            // 
            // textBox_local_port
            // 
            textBox_local_port.Location = new Point(91, 40);
            textBox_local_port.Name = "textBox_local_port";
            textBox_local_port.Size = new Size(152, 23);
            textBox_local_port.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 2;
            label2.Text = "本地监听端口";
            // 
            // textBox_remote_ip
            // 
            textBox_remote_ip.Location = new Point(91, 73);
            textBox_remote_ip.Name = "textBox_remote_ip";
            textBox_remote_ip.Size = new Size(152, 23);
            textBox_remote_ip.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 4;
            label3.Text = "远程接收IP";
            // 
            // textBox_remote_port
            // 
            textBox_remote_port.Location = new Point(91, 106);
            textBox_remote_port.Name = "textBox_remote_port";
            textBox_remote_port.Size = new Size(152, 23);
            textBox_remote_port.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 6;
            label4.Text = "远程接收端口";
            // 
            // button1
            // 
            button1.Location = new Point(12, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "读取配置";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 218);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "开始服务";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "TCP", "UDP" });
            comboBox1.Location = new Point(91, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 25);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 138);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 11;
            label5.Text = "协议";
            // 
            // button3
            // 
            button3.Location = new Point(168, 218);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "停止服务";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(168, 189);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "保存配置";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 271);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(256, 22);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(71, 17);
            toolStripStatusLabel1.Text = "状态:未启动";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 17);
            // 
            // checkBox_AutoStart
            // 
            checkBox_AutoStart.AutoSize = true;
            checkBox_AutoStart.Location = new Point(91, 166);
            checkBox_AutoStart.Name = "checkBox_AutoStart";
            checkBox_AutoStart.Size = new Size(99, 21);
            checkBox_AutoStart.TabIndex = 15;
            checkBox_AutoStart.Text = "自动启动服务";
            checkBox_AutoStart.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            statusStrip2.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel3 });
            statusStrip2.Location = new Point(0, 249);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(256, 22);
            statusStrip2.TabIndex = 16;
            statusStrip2.Text = "提示信息：";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(44, 17);
            toolStripStatusLabel3.Text = "提示：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(256, 293);
            Controls.Add(statusStrip2);
            Controls.Add(checkBox_AutoStart);
            Controls.Add(statusStrip1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_remote_port);
            Controls.Add(label4);
            Controls.Add(textBox_remote_ip);
            Controls.Add(label3);
            Controls.Add(textBox_local_port);
            Controls.Add(label2);
            Controls.Add(textBox_local_ip);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "TCP&UDP转发工具";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_local_ip;
        private TextBox textBox_local_port;
        private Label label2;
        private TextBox textBox_remote_ip;
        private Label label3;
        private TextBox textBox_remote_port;
        private Label label4;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label5;
        private Button button3;
        private Button button4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private CheckBox checkBox_AutoStart;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}