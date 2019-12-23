using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class FactoryB
    {
        public int Q { get; } = Dependency.Q;
        public ClassB Create()
        {
            return new ClassB(new FactoryC(), Q);
        }
    }
}
