using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    class MockFactoryC : IFactoryC
    {
        public IFactoryD FactoryD => null;

        public int O => 0;

        public int P => 0;

        public IClassC Create()
        {
            return null;
        }
    }
    public class ClassBSpec
    {
        [Fact]
        public void Create()
        {
            IFactoryC mockFactoryC = new MockFactoryC();
            var factoryB = new FactoryB(mockFactoryC, 5);

            //Act
            var classB = factoryB.Create();

            //Assert
            classB.Q.Should().Be(5);
        }
    }
}