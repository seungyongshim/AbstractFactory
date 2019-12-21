using Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibA
{
    public class FactoryA : IFactoryA
    {
        public IClassA Create()
        {
            return new ClassA(IFactoryB );
        }
    }
}
