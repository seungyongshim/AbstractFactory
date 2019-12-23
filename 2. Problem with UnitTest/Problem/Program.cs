using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var classA = new ClassA(
                Dependency.M,
                Dependency.N,
                Dependency.O,
                Dependency.P,
                Dependency.Q,
                Dependency.R);
        }
    }
}
