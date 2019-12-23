using FluentAssertions;
using Xunit;
using Moq;

namespace Solution.Tests
{
    public class ClassASpec
    {
        [Fact]
        public void CreateWithMoq()
        {
            //Arrange
            var mockFactoryB = new Mock<IFactoryB>();
            //Act
            var classA = new ClassA(mockFactoryB.Object,
                Dependency.R);

            //Assert
            classA.R.Should().Be(Dependency.R);
        }
    }
}