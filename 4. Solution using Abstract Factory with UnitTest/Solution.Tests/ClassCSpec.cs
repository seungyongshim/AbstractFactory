using FluentAssertions;
using Xunit;

namespace Solution.Tests
{
    class MockFactoryD : IFactoryD
    {
        public int M => default;
        public int N => default;
        public ClassD Create() => default;
    }

    public class ClassCSpec
    {
        [Fact]
        public void CreateWithMock()
        {
            //Act
            var classC = new ClassC(new MockFactoryD(), 
                Dependency.O,
                Dependency.P);

            //Assert
            classC.O.Should().Be(Dependency.O);
            classC.P.Should().Be(Dependency.P);
        }
    }
}