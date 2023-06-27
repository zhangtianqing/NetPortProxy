using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetPortProxy.Bridge
{
    public class UdpBridge : BaseBridge
    {
        UdpClient udpClient;
        Socket server;
        protected override void Open()
        {
            udpClient = new UdpClient();
            udpClient.Connect(IPAddress.Parse(ProxyConfig.remoteAddress), ProxyConfig.remotePort);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            server.Bind(new IPEndPoint(IPAddress.Parse(ProxyConfig.localAddress), ProxyConfig.localPort));

            Task.Run(async () =>
            {
                while (serverState)
                {
                    int count = server.Receive(RecvBuffer);
                    if (count > 0)
                    {
                        udpClient.Send(RecvBuffer, count);
                    }
                    await Task.Delay(0);
                }
            });
        }

        protected override void Close()
        {
            udpClient?.Dispose();
            udpClient?.Close();

            server?.Dispose();
            server?.Close();
        }
    }
}
