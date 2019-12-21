// http://codinghelmet.com/articles/cascading-abstract-factories
using Lib;
using LibA;
using LibB;
using LibC;
using LibD;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryD factoryD = new FactoryD();
            IFactoryC factoryC = new FactoryC(factoryD);
            IFactoryB factoryB = new FactoryB(factoryC);
            IFactoryA factoryA = new FactoryA(factoryB);

            var classA = factoryA.Create();

            Console.WriteLine(classA);
        }
    }
}
