using FluentAssertions;
using Xunit;

namespace Solution.Tests
{
    class MockFactoryC : IFactoryC
    {
        public int O => default;
        public int P => default;
        public ClassC Create() => default;
    }
    public class ClassBSpec
    {
        [Fact]
        public void CreateWithMock()
        {
            //Act
            var classB = new ClassB(new MockFactoryC(),
                Dependency.Q);

            //Assert
            classB.Q.Should().Be(Dependency.Q);
        }
    }
}