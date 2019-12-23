namespace Problem
{
    public class ClassD : IClassD
    {

        public ClassD(int m, int n)
        {
            M = m;
            N = n;
        }

        public int M { get; }
        public int N { get; }
    }
}