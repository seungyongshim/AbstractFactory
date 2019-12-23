using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    public class ClassASpec
    {
        [Fact]
        public void Create()
        {
            var factoryD = new FactoryD(1, 2);
            var factoryC = new FactoryC(factoryD, 3, 4);
            var factoryB = new FactoryB(factoryC, 5);
            var factoryA = new FactoryA(factoryB, 6);

            //Act
            var classA = factoryA.Create();

            //Assert
            classA.ClassB.ClassC.ClassD.M.Should().Be(1);
            classA.ClassB.ClassC.ClassD.N.Should().Be(2);
            classA.ClassB.ClassC.O.Should().Be(3);
            classA.ClassB.ClassC.P.Should().Be(4);
            classA.ClassB.Q.Should().Be(5);
            classA.R.Should().Be(6);
        }
    }
}