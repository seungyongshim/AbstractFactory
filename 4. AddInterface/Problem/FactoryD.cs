namespace Problem
{
    public class FactoryD : IFactoryD
    {
        public FactoryD(int m, int n)
        {
            M = m;
            N = n;
        }

        public IClassD Create()
        {
            return new ClassD(M, N);
        }

        public int M { get; }
        public int N { get; }
    }
}