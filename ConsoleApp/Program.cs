using Autofac;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();

            return builder.Build();
        }
    }
}
