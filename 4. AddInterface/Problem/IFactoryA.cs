namespace Problem
{
    public interface IFactoryA
    {
        IFactoryB FactoryB { get; }
        int R { get; }

        IClassA Create();
    }
}