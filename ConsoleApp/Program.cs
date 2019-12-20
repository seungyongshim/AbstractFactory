// http://codinghelmet.com/articles/cascading-abstract-factories
using System;
using AbstractFactory;
using AbstractFactory.Impl;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryA = new FactoryA();
            var factoryB = new FactoryB();
            var factoryC = new FactoryC();
            var factoryD = new FactoryD();


        }
    }
}
