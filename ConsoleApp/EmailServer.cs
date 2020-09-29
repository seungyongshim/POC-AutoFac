using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class EmailServer : IEmailServer
    {
        public EmailServer(string serverAddress)
        {
            ServerAddress = serverAddress;
        }

        public string ServerAddress { get; }

        public void SendMessage(string toAddress, string fromAddress, string message)
        {
            // ...send the message through the specified server address.
        }
    }
}
