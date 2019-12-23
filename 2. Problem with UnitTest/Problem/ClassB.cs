namespace Problem
{
    public class ClassB
    {

        public ClassB(int m, int n, int o, int p, int q)
        {
            ClassC = new ClassC(m, n, o, p);
            Q = q;
        }

        public ClassC ClassC { get; }
        public int Q { get; }
    }
}