using LibB;
using System;

namespace LibC
{
    public class ClassC : IClassC
    {
        IClassD _classD;

        public ClassC(IClassD classD)
        {
            _classD = classD;
        }

        public override string ToString()
        {
            return $"{nameof(ClassC)} -> {_classD.ToString()}";
        }
    }
}
