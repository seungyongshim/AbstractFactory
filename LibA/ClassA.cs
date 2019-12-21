using Lib;
using System;

namespace LibA
{
    internal class ClassA : IClassA
    {
        IClassB _classB;

        public ClassA(IFactoryB factoryB)
        {
            _classB = factoryB.Create();
        }

        public override string ToString()
        {
            return $"ClassA -> {_classB.ToString()}";
        }
    }
}
