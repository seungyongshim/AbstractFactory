namespace Problem
{
    public class FactoryC
    {
        public FactoryC(FactoryD factoryD, int o, int p)
        {
            FactoryD = factoryD;
            O = o;
            P = p;
        }

        public ClassC Create()
        {
            return new ClassC(FactoryD, O, P);
        }

        public FactoryD FactoryD { get; }
        public int O { get; }
        public int P { get; }
    }
}