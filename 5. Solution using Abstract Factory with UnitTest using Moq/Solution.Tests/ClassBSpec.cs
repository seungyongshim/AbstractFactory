using FluentAssertions;
using Moq;
using Xunit;

namespace Solution.Tests
{
    public class ClassBSpec
    {
        [Fact]
        public void CreateWithMoq()
        {
            //Arrange
            var mockFactoryC = new Mock<IFactoryC>();
            //Act
            var classB = new ClassB(mockFactoryC.Object,
                Dependency.Q);

            //Assert
            classB.Q.Should().Be(Dependency.Q);
        }
    }
}