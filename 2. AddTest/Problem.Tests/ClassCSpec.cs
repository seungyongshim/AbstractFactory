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
            var classC = new ClassC(1, 2, 3, 4);

            //Assert
            classC.ClassD.M.Should().Be(1);
            classC.ClassD.N.Should().Be(2);
            classC.O.Should().Be(3);
            classC.P.Should().Be(4);
        }
    }
}