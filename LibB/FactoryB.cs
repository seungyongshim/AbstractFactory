using LibA;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibB
{
    public class FactoryB : IFactoryB
    {
        public IClassB Create(IFactoryC factoryC)
        {
            return new ClassB(factoryC);
        }

        public IClassB Create()
        {
            throw new ClassB();
        }
    }
}
