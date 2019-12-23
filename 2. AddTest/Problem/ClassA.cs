namespace Problem
{
    public class ClassA
    {
        public ClassA(int m, int n, int o, int p, int q, int r)
        {
            ClassB = new ClassB(m, n, o, p,q);
            R = r;
        }

        public ClassB ClassB { get; }
        public int R { get; }
    }
}