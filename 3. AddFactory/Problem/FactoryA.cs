namespace Problem
{
    public class FactoryA
    {
        public FactoryA(FactoryB factoryB, int r)
        {
            FactoryB = factoryB;
            R = r;
        }

        public ClassA Create()
        {
            return new ClassA(FactoryB, R);
        }

        public FactoryB FactoryB { get; }
        public int R { get; }
    }
}