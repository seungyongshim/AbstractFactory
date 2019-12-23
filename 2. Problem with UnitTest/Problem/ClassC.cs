namespace Problem
{
    public class ClassC
    {
        public ClassD ClassD { get; }
        public int O { get; }
        public int P { get; }

        public ClassC(int m, int n, int o, int p)
        {
            ClassD = new ClassD(m, n);
            O = o;
            P = p;
        }
    }
}