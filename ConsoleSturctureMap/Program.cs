// http://codinghelmet.com/articles/cascading-abstract-factories
using Lib;
using LibA;
using LibB;
using LibC;
using LibD;
using StructureMap;
using System;

namespace ConsoleStructureMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(c =>
            {
                c.For<IClassA>().Use<ClassA>();
                c.For<IClassB>().Use<ClassB>();
                c.For<IClassC>().Use<ClassC>();
                c.For<IClassD>().Use<ClassD>();
            });

            var classA = container.GetInstance<IClassA>();

            Console.WriteLine(classA);
        }
    }
}
