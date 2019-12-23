using System;

namespace Solution
{
    public class FactoryC
    {
        public int O { get; } = Dependency.O;
        public int P { get; } = Dependency.P;

        public ClassC Create()
        {
            return new ClassC(new FactoryD(), O, P);
        }
    }
}