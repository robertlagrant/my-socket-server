using System;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;

namespace mysocketserver
{
    public class TelnetServer : AppServer<TelnetSession>
    {
        protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
        {
            return base.Setup(rootConfig, config);
        }

        protected override void OnStopped()
        {
            base.OnStopped();
        }
    }
}
