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
            var classB = new ClassB(1, 2, 3, 4, 5);

            //Assert
            classB.ClassC.ClassD.M.Should().Be(1);
            classB.ClassC.ClassD.N.Should().Be(2);
            classB.ClassC.O.Should().Be(3);
            classB.ClassC.P.Should().Be(4);
            classB.Q.Should().Be(5);
        }
    }
}