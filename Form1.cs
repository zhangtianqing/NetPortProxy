using NetPortProxy.Bridge;
using System.Net;
using System.Net.Sockets;

namespace NetPortProxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("SlectIndex:" + this.comboBox1.SelectedIndex);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 读取配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            proxyConfig.SaveProxyConfig(this.textBox_remote_ip.Text, int.Parse(this.textBox_remote_port.Text), this.textBox_local_ip.Text, int.Parse(this.textBox_local_port.Text), this.checkBox_AutoStart.Checked, this.comboBox1.SelectedIndex);
        }
        /// <summary>
        /// 开启服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            OpenServer();
        }
        /// <summary>
        /// 关闭服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            CloseServer();
        }

        ProxyConfig proxyConfig = new ProxyConfig();


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
            if (proxyConfig.autoStart)
            {
                OpenServer();
            }

        }

        private void LoadConfig()
        {
            proxyConfig.LoadConfig();
            this.checkBox_AutoStart.Checked = proxyConfig.autoStart;

            this.textBox_local_ip.Text = proxyConfig.localAddress;
            this.textBox_local_port.Text = proxyConfig.localPort + "";

            this.textBox_remote_ip.Text = proxyConfig.remoteAddress;
            this.textBox_remote_port.Text = proxyConfig.remotePort + "";

            this.comboBox1.SelectedIndex = proxyConfig.protocol;
        }

        bool serverState = false;

        int serverModel = -1;
        void OpenServer()
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
                this.toolStripStatusLabel1.Text = "已启动";
            }
            catch (Exception e)
            {
                CloseServer();
                MessageBox.Show("启动异常：" + e.Message);
            }

        }
        BaseBridge baseBridge;


        void UpdateLog(string str)
        {
            this.toolStripStatusLabel3.Text = $"提示信息：{str}";
        }
        void CloseServer()
        {
            baseBridge?.CloseServer();
            serverModel = -1;
            this.toolStripStatusLabel1.Text = "已停止";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseServer();
        }
    }
    public class ProxyConfig
    {
        public string remoteAddress = "";
        public int remotePort;
        public string localAddress = "";
        public int localPort;
        public bool autoStart = false;
        public int protocol = 0;

        public ProxyConfig()
        {
            LoadConfig();
        }
        public void LoadConfig()
        {

            this.autoStart = INIHelper.GetBool(nameof(autoStart));

            this.remoteAddress = INIHelper.GetString(nameof(remoteAddress));
            this.remotePort = INIHelper.GetInt(nameof(remotePort));
            this.localAddress = INIHelper.GetString(nameof(localAddress));
            this.localPort = INIHelper.GetInt(nameof(localPort));

            this.protocol = INIHelper.GetInt(nameof(protocol));
        }

        public bool SaveProxyConfig(string remoteAddress, int remotePort, string localAddress, int localPort, bool autoStart, int protocol)
        {
            this.remoteAddress = remoteAddress;
            this.remotePort = remotePort;
            this.localAddress = localAddress;
            this.localPort = localPort;
            this.autoStart = autoStart;
            this.protocol = protocol;
            INIHelper.WriteBool(nameof(autoStart), INIHelper.SectionName.config, this.autoStart);

            INIHelper.WriteString(nameof(remotePort), INIHelper.SectionName.config, this.remotePort + "");
            INIHelper.WriteString(nameof(remoteAddress), INIHelper.SectionName.config, this.remoteAddress + "");

            INIHelper.WriteString(nameof(localPort), INIHelper.SectionName.config, this.localPort + "");
            INIHelper.WriteString(nameof(localAddress), INIHelper.SectionName.config, this.localAddress + "");

            INIHelper.WriteString(nameof(protocol), INIHelper.SectionName.config, this.protocol + "");
            MessageBox.Show("保存成功");
            return true;
        }
    }
}