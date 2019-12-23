using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryD = new FactoryD(1, 2);
            var factoryC = new FactoryC(factoryD, 3, 4);
            var factoryB = new FactoryB(factoryC, 5);
            var factoryA = new FactoryA(factoryB, 6);

            //Act
            var classA = factoryA.Create();
        }
    }
}
