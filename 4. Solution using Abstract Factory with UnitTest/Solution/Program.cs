using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var classA = new ClassA(new FactoryB(), Dependency.R);
        }
    }
}
