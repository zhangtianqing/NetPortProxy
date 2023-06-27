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
    public class TcpBridge : BaseBridge
    {
        Socket tcpServer;
        Socket tcpClient;


        protected override void Open()
        {
            //if (tcpServer != null || tcpClient != null || serverState)
            //{
            //    return;
            //}

            tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpServer.Bind(new IPEndPoint(IPAddress.Parse(ProxyConfig.localAddress), ProxyConfig.localPort));
            tcpServer.Listen(1);

            tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpClient.BeginConnect(new IPEndPoint(IPAddress.Parse(ProxyConfig.remoteAddress), ProxyConfig.remotePort), TcpConnectCall, tcpClient);

            tcpServer.BeginAccept(Accept, tcpServer);
        }
        private void Accept(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            try
            {
                Socket socket1 = socket.EndAccept(ar);
                if (serverState)
                {
                    socket1.BeginReceive(RecvBuffer, 0, RecvBuffer.Length, SocketFlags.None, TcpServerRecvCallback, socket1);
                }
            }
            catch (Exception e)
            {
                logCallback?.Invoke("AcceptError:" + e.Message);
                if (serverState)
                {
                    tcpServer.BeginAccept(Accept, tcpServer);
                }
            }

        }

        private void TcpServerRecvCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int count = socket.EndReceive(ar);
            if (count > 0)
            {
                tcpClient.Send(RecvBuffer, 0, count, SocketFlags.None, out SocketError error);
                if (error != SocketError.Success)
                {
                    logCallback?.Invoke("TcpServerRecvCallback:" + error);
                    Console.WriteLine(error);
                }
            }
            if (serverState)
            {
                try
                {
                    socket.BeginReceive(RecvBuffer, 0, RecvBuffer.Length, SocketFlags.None, TcpServerRecvCallback, socket);
                }
                catch (Exception)
                {
                    tcpServer.BeginAccept(Accept, tcpServer);
                }
            }
            else
            {
                socket.Close();
                tcpServer.Close();
                tcpClient.Close();
            }
        }

        private void TcpConnectCall(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            try
            {
                socket?.EndConnect(ar);

                if (serverState)
                {
                    if (socket != null)
                    {
                        logCallback?.Invoke("TCP成功连上远程服务");
                    }
                }
            }
            catch (Exception e)
            {
                if (serverState)
                {
                    tcpClient.BeginConnect(new IPEndPoint(IPAddress.Parse(ProxyConfig.remoteAddress), ProxyConfig.remotePort), TcpConnectCall, tcpClient);
                }
            }

        }
        protected override void Close()
        {
            tcpServer?.Close();
            tcpClient?.Close();
        }
    }
}
