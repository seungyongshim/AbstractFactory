namespace Problem
{
    public class ClassA
    {
        public ClassA(FactoryB factoryB, int r)
        {
            ClassB = factoryB.Create();
            R = r;
        }

        public ClassB ClassB { get; }
        public int R { get; }
    }
}