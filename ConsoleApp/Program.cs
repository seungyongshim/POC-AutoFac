using Autofac;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositionRoot().Resolve<Application>().Run();
        }

        static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>();
            builder.RegisterType<Notifier>().As<INotifier>();
            //builder.RegisterType<EmailServer>().As<EmailServer>();
            builder.RegisterType<EmailServer>().As<IEmailServer>().WithParameter("serverAddress", "2222");

            return builder.Build();
        }
    }
}
