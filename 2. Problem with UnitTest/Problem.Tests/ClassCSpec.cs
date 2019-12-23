using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    public class ClassCSpec
    {
        [Fact]
        public void Create()
        {
            //Act
            var classC = new ClassC(
                Dependency.M,
                Dependency.N,
                Dependency.O,
                Dependency.P);

            //Assert
            classC.O.Should().Be(Dependency.O);
            classC.P.Should().Be(Dependency.P);
        }
    }
}