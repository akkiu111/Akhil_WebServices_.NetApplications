using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloRemotingService.HelloRemotingService remotingService = new
                HelloRemotingService.HelloRemotingService();
            TcpChannel channel = new TcpChannel(8081);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(HelloRemotingService.HelloRemotingService),
                "GetMessage",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("Remoting service started @ " + DateTime.Now);
            Console.ReadLine();
        }
    }
}
