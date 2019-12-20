namespace AbstractFactory.Impl
{
    public class FactoryA : IFactoryA
    {
        public IClassA Create()
        {
            return new ClassA();
        }
    }
}