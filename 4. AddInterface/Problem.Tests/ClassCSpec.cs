using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    class MockFactoryD : IFactoryD
    {
        public int M => 0;

        public int N => 0;

        public IClassD Create()
        {
            return null;
        }
    }

    public class ClassCSpec
    {
        [Fact]
        void Create()
        {
            IFactoryD mockFactoryD = new MockFactoryD();
            var factoryC = new FactoryC(mockFactoryD, 3, 4);

            //Act
            var classC = factoryC.Create();

            // Assert
            classC.O.Should().Be(3);
            classC.P.Should().Be(4);
        }
    }
}