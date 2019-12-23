namespace Problem
{
    public class ClassA : IClassA
    {
        public ClassA(IFactoryB factoryB, int r)
        {
            ClassB = factoryB.Create();
            R = r;
        }

        public IClassB ClassB { get; }
        public int R { get; }
    }
}