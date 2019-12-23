using System;
using Xunit;
using FluentAssertions;

namespace Problem.Tests
{
    public class ClassDSpec
    {
        [Fact]
        void Create()
        {
            IFactoryD factoryD = new FactoryD(1, 2);

            //Act
            var classD = factoryD.Create();

            // Assert
            classD.M.Should().Be(1);
            classD.N.Should().Be(2);
        }
    }
}
