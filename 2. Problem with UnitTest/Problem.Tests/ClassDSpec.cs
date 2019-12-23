using System;
using Xunit;
using FluentAssertions;

namespace Problem.Tests
{
    public class ClassDSpec
    {
        [Fact]
        public void Create()
        {
            // Arrange
            // Act
            var classD = new ClassD(
                Dependency.M,
                Dependency.N);

            // Assert
            classD.M.Should().Be(Dependency.M);
            classD.N.Should().Be(Dependency.N);
        }
    }
}
