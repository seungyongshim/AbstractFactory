namespace AbstractFactory.Impl
{
    public class FactoryB : IFactoryB
    {
        public IClassB Create()
        {
            return new ClassB();
        }
    }
}