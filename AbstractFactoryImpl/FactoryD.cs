namespace AbstractFactory.Impl
{
    public class FactoryD : IFactoryD
    {
        public IClassD Create()
        {
            return new ClassD();
        }
    }
}