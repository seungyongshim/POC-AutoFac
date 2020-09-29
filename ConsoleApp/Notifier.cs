using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Notifier : INotifier
    {
        public IEmailServer Server { get; }

        public void Send(string address, string message)
        {
            Server.SendMessage(address, "from@domain.com", message);
        }

        public Notifier(IEmailServer server)
        {
            Server = server;
        }
    }
}
