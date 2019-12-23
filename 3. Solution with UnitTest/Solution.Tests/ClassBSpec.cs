using FluentAssertions;
using Xunit;

namespace Solution.Tests
{
    public class ClassBSpec
    {
        [Fact]
        public void Create()
        {
            //Act
            var classB = new ClassB(new FactoryC(),
                Dependency.Q);

            //Assert
            classB.Q.Should().Be(Dependency.Q);
        }
    }
}