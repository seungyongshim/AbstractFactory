using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using Lib;
using LibA;
using LibB;
using LibC;
using LibD;

namespace ConsoleCastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            container.Register(Component.For<IClassA>().ImplementedBy<ClassA>());
            container.Register(Component.For<IClassB>().ImplementedBy<ClassB>());
            container.Register(Component.For<IClassC>().ImplementedBy<ClassC>());
            container.Register(Component.For<IClassD>().ImplementedBy<ClassD>());

            var classA = container.Resolve<IClassA>();
            Console.WriteLine(classA);
        }
    }
}
