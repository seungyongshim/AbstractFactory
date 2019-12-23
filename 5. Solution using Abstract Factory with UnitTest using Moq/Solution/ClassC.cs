namespace Solution
{
    public class ClassC
    {
        public ClassD ClassD { get; }
        public int O { get; }
        public int P { get; }

        public ClassC(IFactoryD factoryD, int o, int p)
        {
            ClassD = factoryD.Create();
            O = o;
            P = p;
        }
    }
}