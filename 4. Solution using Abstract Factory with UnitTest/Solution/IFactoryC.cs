namespace Solution
{
    public interface IFactoryC
    {
        int O { get; }
        int P { get; }

        ClassC Create();
    }
}