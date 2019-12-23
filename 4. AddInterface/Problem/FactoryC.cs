namespace Problem
{
    public class FactoryC : IFactoryC
    {
        public FactoryC(IFactoryD factoryD, int o, int p)
        {
            FactoryD = factoryD;
            O = o;
            P = p;
        }

        public IClassC Create()
        {
            return new ClassC(FactoryD, O, P);
        }

        public IFactoryD FactoryD { get; }
        public int O { get; }
        public int P { get; }
    }
}