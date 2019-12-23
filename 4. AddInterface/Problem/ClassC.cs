namespace Problem
{
    public class ClassC : IClassC
    {
        public IClassD ClassD { get; }
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