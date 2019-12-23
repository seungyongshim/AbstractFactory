using Autofac;
using Lib;
using LibA;
using LibB;
using LibC;
using LibD;
using System;

namespace ConsoleAutoFac
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ClassA>().As<IClassA>();
            builder.RegisterType<ClassB>().As<IClassB>();
            builder.RegisterType<ClassC>().As<IClassC>();
            builder.RegisterType<ClassD>().As<IClassD>();

            var container = builder.Build();

            var classA = container.Resolve<IClassA>();
            Console.WriteLine(classA);
        }
    }
}
