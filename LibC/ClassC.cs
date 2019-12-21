using LibB;
using System;

namespace LibC
{
    internal class ClassC : IClassC
    {
        IClassD _classD;

        public ClassC(IFactoryD factoryD)
        {
            _classD = factoryD.Create();
        }

        public override string ToString()
        {
            return $"{nameof(ClassC)} -> {_classD.ToString()}";
        }
    }
}
