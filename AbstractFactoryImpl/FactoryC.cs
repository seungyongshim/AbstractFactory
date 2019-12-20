namespace AbstractFactory.Impl
{
    public class FactoryC : IFactoryC
    {
        public IClassC Create()
        {
            return new ClassC();
        }
    }
}