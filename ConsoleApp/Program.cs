// http://codinghelmet.com/articles/cascading-abstract-factories
using Lib;
using LibA;
using LibB;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryA factoryA = new FactoryA();
            IFactoryB factoryB = new FactoryB();
            IFactoryC factoryC = new FactoryC();



        }
    }
}
