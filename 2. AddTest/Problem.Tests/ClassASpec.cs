using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    public class ClassASpec
    {
        [Fact]
        public void Create()
        {
            //Act
            var classA = new ClassA(1, 2, 3, 4, 5, 6);

            //Assert
            classA.ClassB.ClassC.ClassD.M.Should().Be(1);
            classA.ClassB.ClassC.ClassD.N.Should().Be(2);
            classA.ClassB.ClassC.O.Should().Be(3);
            classA.ClassB.ClassC.P.Should().Be(4);
            classA.ClassB.Q.Should().Be(5);
        }
    }
}