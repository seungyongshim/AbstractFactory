namespace Problem
{
    public class ClassC
    {
        private ClassD _classD;
        private int _o;
        private int _p;

        public ClassC(int m, int n, int o, int p)
        {
            _classD = new ClassD(m, n);
            _o = o;
            _p = p;
        }
    }
}