using Lib;
using System;

namespace LibA
{
    public class ClassA : IClassA
    {
        IClassB _classB;
        
        public ClassA(IClassB classB)
        {
            _classB = classB;
        }
        public override string ToString()
        {
            return $"ClassA -> {_classB.ToString()}";
        }
    }
}
