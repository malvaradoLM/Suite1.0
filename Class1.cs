using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemObjects.SDK;
using RemObjects.DataAbstract;

namespace RPSuite
{
    class Class1
    {
        private RemObjects.SDK.BinMessage message;
        private RemObjects.SDK.IClientChannel channel;
        public RPSuiteServer.IRPLoginService service;
        private RemObjects.SDK.RemoteService remoteService;
        private RemObjects.DataAbstract.Server.UserInfo userInfo;

        private void something()
        {
            channel.TargetUrl= "http://localhost:9200/bin";
            message =new BinMessage();
            remoteService.Channel=channel;
            remoteService.CloneMessage=true;
            remoteService.Message=message;
            service = RPSuiteServer.CoRPLoginService.Create(remoteService);
            service.Login("super", "cistem", out userInfo);
        }
    }
}
