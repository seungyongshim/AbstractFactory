namespace Problem
{
    public interface IFactoryD
    {
        int M { get; }
        int N { get; }

        IClassD Create();
    }
}