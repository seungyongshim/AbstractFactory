using FluentAssertions;
using Moq;
using Xunit;

namespace Solution.Tests
{
    public class ClassCSpec
    {
        [Fact]
        public void CreateWithMoq()
        {
            //Arrange
            var mockFactoryD = new Mock<IFactoryD>();
            //Act
            var classC = new ClassC(mockFactoryD.Object, 
                Dependency.O,
                Dependency.P);

            //Assert
            classC.O.Should().Be(Dependency.O);
            classC.P.Should().Be(Dependency.P);
        }
    }
}