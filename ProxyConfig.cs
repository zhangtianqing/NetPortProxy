using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetPortProxy
{

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
            Form1.ins.LogMsg("保存成功");
            return true;
        }
    }
}
