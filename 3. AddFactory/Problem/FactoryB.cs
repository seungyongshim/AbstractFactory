namespace Problem
{
    public class FactoryB
    {
        public FactoryB(FactoryC factoryC, int q)
        {
            FactoryC = factoryC;
            Q = q;
        }

        public ClassB Create()
        {
            return new ClassB(FactoryC, Q);
        }

        public FactoryC FactoryC { get; }
        public int Q { get; }
    }
}