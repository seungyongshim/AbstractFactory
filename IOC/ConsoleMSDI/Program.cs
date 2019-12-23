// https://docs.microsoft.com/en-us/archive/msdn-magazine/2016/june/essential-net-dependency-injection-with-net-core
using System;
using Microsoft.Extensions.DependencyInjection;
using Lib;
using LibA;
using LibB;
using LibC;
using LibD;

namespace ConsoleMSDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IClassA, ClassA>();
            serviceCollection.AddTransient<IClassB, ClassB>();
            serviceCollection.AddTransient<IClassC, ClassC>();
            serviceCollection.AddTransient<IClassD, ClassD>();

            var service = serviceCollection.BuildServiceProvider();
            var classA = service.GetService<IClassA>();

            Console.WriteLine(classA);
        }
    }
}
