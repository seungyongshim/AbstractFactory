namespace Problem
{
    public interface IFactoryC
    {
        IFactoryD FactoryD { get; }
        int O { get; }
        int P { get; }

        IClassC Create();
    }
}