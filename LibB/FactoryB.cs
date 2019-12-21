using LibA;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibB
{
    public class FactoryB : IFactoryB
    {
        private IFactoryC _factoryC;

        public FactoryB(IFactoryC factoryC)
        {
            _factoryC = factoryC;
        }

        public IClassB Create()
        {
            return new ClassB(_factoryC);
        }
    }
}
