using FluentAssertions;
using Xunit;

namespace Solution.Tests
{
    class MockFactoryB : IFactoryB
    {
        public int Q => default;
        public ClassB Create => default;
    }

    public class ClassASpec
    {
        [Fact]
        public void CreateWithMock()
        {
            //Act
            var classA = new ClassA(new MockFactoryB(),
                Dependency.R);

            //Assert
            classA.R.Should().Be(Dependency.R);
        }
    }
}