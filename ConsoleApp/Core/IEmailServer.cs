using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    interface IEmailServer
    {
        void SendMessage(string toAddress, string fromAddress, string message);
    }
}
