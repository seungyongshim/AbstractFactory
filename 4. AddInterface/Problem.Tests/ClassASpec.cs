using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    class MockFactoryB : IFactoryB
    {
        public IFactoryC FactoryC => null;
        public int Q => 0;
        public IClassB Create() => null;
    }

    public class ClassASpec
    {
        [Fact]
        public void Create()
        {
            IFactoryB mockFactoryB = new MockFactoryB();
            var factoryA = new FactoryA(mockFactoryB, 6);

            //Act
            var classA = factoryA.Create();

            //Assert
            classA.R.Should().Be(6);
        }
    }
}