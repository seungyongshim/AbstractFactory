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
            var classA = new ClassA(
                Dependency.M,
                Dependency.N,
                Dependency.O,
                Dependency.P,
                Dependency.Q,
                Dependency.R);

            //Assert
            classA.R.Should().Be(Dependency.R);
        }
    }
}