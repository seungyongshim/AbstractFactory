using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    public class ClassBSpec
    {
        [Fact]
        public void Create()
        {
            var factoryD = new FactoryD(1, 2);
            var factoryC = new FactoryC(factoryD, 3, 4);
            var factoryB = new FactoryB(factoryC, 5);

            //Act
            var classB = factoryB.Create();

            //Assert
            classB.ClassC.ClassD.M.Should().Be(1);
            classB.ClassC.ClassD.N.Should().Be(2);
            classB.ClassC.O.Should().Be(3);
            classB.ClassC.P.Should().Be(4);
            classB.Q.Should().Be(5);
        }
    }
}