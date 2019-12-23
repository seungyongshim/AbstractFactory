namespace Problem
{
    public class FactoryD
    {
        public FactoryD(int m, int n)
        {
            M = m;
            N = n;
        }

        public ClassD Create()
        {
            return new ClassD(M, N);
        }

        public int M { get; }
        public int N { get; }
    }
}