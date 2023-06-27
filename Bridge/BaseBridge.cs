using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPortProxy
{
    public class BaseBridge : BridgeInterface
    {
        public bool serverState;
        public ProxyConfig ProxyConfig;
        public Action<string> logCallback;
        protected byte[] RecvBuffer = new byte[512];
        public void OpenServer()
        {
            if (serverState)
            {
                return;
            }
            Open();
            serverState = true;
        }

        public void CloseServer()
        {
            if (!serverState)
            {
                return;
            }
            Close();
            serverState = false;
        }
        protected virtual void Close() { }
        protected virtual void Open() { }
    }

    public interface BridgeInterface
    {
        void OpenServer();
        void CloseServer();
    }
}
