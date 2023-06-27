using NetPortProxy.Bridge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetPortProxy
{
    public partial class Form1 : Form
    {
        ProxyConfig proxyConfig = new ProxyConfig();
        BaseBridge baseBridge;
        int serverModel = -1;
        public static Form1 ins;
        public Form1()
        {
            InitializeComponent();
            ins = this;
        }
        public void LogMsg(string str)
        {
            if (textBox_Log.Text.Length > 10000)
            {
                textBox_Log.Text = "";
            }
            if (textBox_Log.Text != "")
                textBox_Log.Text += "\r\n";
            textBox_Log.Text += $"{DateTime.Now.ToString("HH:mm:ss")}:{str}";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer(null, null);
        }

        private void LoadConfig(object sender, EventArgs e)
        {
            proxyConfig.LoadConfig();
            this.checkBox_AutoStart.Checked = proxyConfig.autoStart;

            this.textBox_local_ip.Text = proxyConfig.localAddress;
            this.textBox_local_port.Text = proxyConfig.localPort + "";

            this.textBox_remote_ip.Text = proxyConfig.remoteAddress;
            this.textBox_remote_port.Text = proxyConfig.remotePort + "";

            this.comboBox1.SelectedIndex = proxyConfig.protocol;
            LogMsg("配置读取成功");
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            proxyConfig.SaveProxyConfig(this.textBox_remote_ip.Text, int.Parse(this.textBox_remote_port.Text), this.textBox_local_ip.Text, int.Parse(this.textBox_local_port.Text), this.checkBox_AutoStart.Checked, this.comboBox1.SelectedIndex);
        }

        private void StartServer(object sender, EventArgs e)
        {
            if (serverModel != -1)
            {
                return;
            }
            try
            {
                //TCP
                if (this.comboBox1.SelectedIndex == 0)
                {
                    baseBridge = new TcpBridge() { ProxyConfig = proxyConfig };

                }
                else //1 UDP
                {
                    baseBridge = new UdpBridge() { ProxyConfig = proxyConfig };

                }
                baseBridge.logCallback += (str) =>
                {

                };
                baseBridge.OpenServer();

                serverModel = this.comboBox1.SelectedIndex;
                this.toolStripStatusLabel_state.Text = "已启动";
            }
            catch (Exception er)
            {
                StopServer(null, null);
                LogMsg("启动异常：" + er.Message);
            }

        }

        private void StopServer(object sender, EventArgs e)
        {
            baseBridge?.CloseServer();
            serverModel = -1;
            this.toolStripStatusLabel_state.Text = "已停止";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig(null, null);
            if (proxyConfig.autoStart)
            {
                StartServer(null, null);
            }
        }
    }
}
