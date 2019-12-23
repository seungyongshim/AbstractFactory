using System;
using Xunit;
using FluentAssertions;

namespace Solution.Tests
{
    public class ClassDSpec
    {
        [Fact]
        public void Create()
        {
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
