namespace Problem
{
    public class FactoryB : IFactoryB
    {
        public FactoryB(IFactoryC factoryC, int q)
        {
            FactoryC = factoryC;
            Q = q;
        }

        public IClassB Create()
        {
            return new ClassB(FactoryC, Q);
        }

        public IFactoryC FactoryC { get; }
        public int Q { get; }
    }
}