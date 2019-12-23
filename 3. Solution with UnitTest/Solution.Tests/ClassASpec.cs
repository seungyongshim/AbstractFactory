using FluentAssertions;
using Xunit;

namespace Solution.Tests
{
    public class ClassASpec
    {
        [Fact]
        public void Create()
        {
            //Act
            var classA = new ClassA(new FactoryB(),
                Dependency.R);

            //Assert
            classA.R.Should().Be(Dependency.R);
        }
    }
}