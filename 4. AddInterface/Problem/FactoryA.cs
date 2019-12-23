namespace Problem
{
    public class FactoryA : IFactoryA
    {
        public FactoryA(IFactoryB factoryB, int r)
        {
            FactoryB = factoryB;
            R = r;
        }

        public IClassA Create()
        {
            return new ClassA(FactoryB, R);
        }

        public IFactoryB FactoryB { get; }
        public int R { get; }
    }
}