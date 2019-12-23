namespace Solution
{
    public class ClassB
    {
        public ClassB(FactoryC factoryC, int q)
        {
            ClassC = factoryC.Create();
            Q = q;
        }

        public ClassC ClassC { get; }
        public int Q { get; }
    }
}