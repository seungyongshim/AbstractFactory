namespace Solution
{
    public class ClassB
    {
        public ClassB(IFactoryC factoryC, int q)
        {
            ClassC = factoryC.Create();
            Q = q;
        }

        public ClassC ClassC { get; }
        public int Q { get; }
    }
}