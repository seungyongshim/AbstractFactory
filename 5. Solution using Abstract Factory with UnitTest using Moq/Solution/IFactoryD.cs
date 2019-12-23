namespace Solution
{
    public interface IFactoryD
    {
        int M { get; }
        int N { get; }

        ClassD Create();
    }
}