namespace Problem
{
    public class ClassB : IClassB
    {
        public ClassB(IFactoryC factoryC, int q)
        {
            ClassC = factoryC.Create();
            Q = q;
        }

        public IClassC ClassC { get; }
        public int Q { get; }
    }
}