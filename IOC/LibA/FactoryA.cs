using Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibA
{
    public class FactoryA : IFactoryA
    {
        IFactoryB _factoryB { get; }

        public FactoryA(IFactoryB factoryB)
        {
            _factoryB = factoryB;
        }
        
        public IClassA Create()
        {
            return new ClassA(_factoryB.Create());
        }
    }
}
