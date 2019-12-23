using FluentAssertions;
using Xunit;

namespace Solution.Tests
{
    public class ClassCSpec
    {
        [Fact]
        public void Create()
        {
            //Act
            var classC = new ClassC(new FactoryD(), 
                Dependency.O,
                Dependency.P);

            //Assert
            classC.O.Should().Be(Dependency.O);
            classC.P.Should().Be(Dependency.P);
        }
    }
}