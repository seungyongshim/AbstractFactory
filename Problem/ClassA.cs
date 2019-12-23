namespace Problem
{
    internal class ClassA
    {
        private ClassB _classB;
        private int _r;

        public ClassA(int m, int n, int o, int p, int q, int r)
        {
            _classB = new ClassB(m, n, o, p,q);
            _r = r;
        }
    }
}