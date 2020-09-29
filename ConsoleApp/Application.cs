using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Application
    {
        public Application(INotifier notifier)
        {
            Notifier = notifier;
        }

        public INotifier Notifier { get; }

        internal void Run()
        {
            Notifier.Send("1111", "3333");
        }
    }
}
