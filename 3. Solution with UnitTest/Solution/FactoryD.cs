namespace Solution
{
    public class FactoryD
    {
        public int M { get; } = Dependency.M;
        public int N { get; } = Dependency.N;
        public ClassD Create()
        {
            return new ClassD(M, N);
        }
    }
}