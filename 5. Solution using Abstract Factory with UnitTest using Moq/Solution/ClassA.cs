namespace Solution
{
    public class ClassA
    {
        public ClassA(IFactoryB factoryB, int r)
        {
            ClassB = factoryB.Create;
            R = r;
        }

        public ClassB ClassB { get; }
        public int R { get; }
    }
}