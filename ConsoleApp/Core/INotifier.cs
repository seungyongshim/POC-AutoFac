using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public interface INotifier
    {
        void Send(string address, string message);

    }
}
