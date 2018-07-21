using System;

namespace HelloRemotingService
{
    public class HelloRemotingService : MarshalByRefObject, IHelloRemotingService.IHelloRemotingService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
