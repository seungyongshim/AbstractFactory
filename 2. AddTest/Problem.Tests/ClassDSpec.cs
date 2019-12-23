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
            var classD = new ClassD(1, 2);

            // Assert
            classD.M.Should().Be(1);
            classD.N.Should().Be(2);
        }
    }
}
