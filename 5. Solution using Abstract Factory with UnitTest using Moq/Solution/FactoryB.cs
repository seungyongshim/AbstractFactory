using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class FactoryB : IFactoryB
    {
        public int Q { get; } = Dependency.Q;
        public ClassB Create => new ClassB(new FactoryC(), Q);
    }
}
