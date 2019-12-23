using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    public class ClassBSpec
    {
        [Fact]
        public void Create()
        {
            //Act
            var classB = new ClassB(
                Dependency.M,
                Dependency.N,
                Dependency.O,
                Dependency.P,
                Dependency.Q);

            //Assert
            classB.Q.Should().Be(Dependency.Q);
        }
    }
}