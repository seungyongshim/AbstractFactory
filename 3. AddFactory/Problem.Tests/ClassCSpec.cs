using FluentAssertions;
using Xunit;

namespace Problem.Tests
{
    public class ClassCSpec
    {
        [Fact]
        void Create()
        {
            var factoryD = new FactoryD(1, 2);
            var factoryC = new FactoryC(factoryD, 3, 4);

            //Act
            var classC = factoryC.Create();

            // Assert
            classC.ClassD.M.Should().Be(1);
            classC.ClassD.N.Should().Be(2);
            classC.O.Should().Be(3);
            classC.P.Should().Be(4);
        }
    }
}