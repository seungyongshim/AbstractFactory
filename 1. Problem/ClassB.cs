namespace Problem
{
    public class ClassB
    {
        private ClassC _classC;
        private int _q;

        public ClassB(int m, int n, int o, int p, int q)
        {
            _classC = new ClassC(m, n, o, p);
            _q = q;
        }
    }
}