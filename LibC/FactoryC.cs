using LibB;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibC
{
    public class FactoryC : IFactoryC
    {
        IFactoryD _factoryD;
        public IClassC Create()
        {
            return new ClassC(_factoryD);
        }
        public FactoryC(IFactoryD factoryD)
        {
            _factoryD = factoryD;
        }
    }
}
