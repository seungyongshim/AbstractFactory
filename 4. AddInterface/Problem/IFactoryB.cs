namespace Problem
{
    public interface IFactoryB
    {
        IFactoryC FactoryC { get; }
        int Q { get; }

        IClassB Create();
    }
}