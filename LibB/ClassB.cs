using LibA;
using System;

namespace LibB
{
    public class ClassB : IClassB
    {
        IClassC _classC;
        public ClassB(IClassC classC)
        {
            _classC = classC;
        }
        public override string ToString()
        {
            return $"ClassB -> {_classC.ToString()}";
        }
    }
}
