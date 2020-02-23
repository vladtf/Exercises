using Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Problema_1_xUnitTests
{
    public class Test
    {
        [Fact]
        public void Prime_Test()
        {
            // Arrange 
            bool expected = true;

            // Act 
            bool actual = Obiect.Prime(3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prime_Test_FalseEpected()
        {
            // Arrange 
            bool expected = true;

            // Act 
            bool actual = Obiect.Prime(4);

            // Assert
            Assert.NotEqual(expected, actual);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(41)]
        [InlineData(19)]
        public void Prime_MultipleTests_ExpectedTrue(int x)
        {
            // Arrange 
            bool expected = true;

            // Act 
            bool actual = Obiect.Prime(x);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("asd")]
        public void Prime_Test_Throws_WronFormatException(dynamic x)
        {
            // Arrange 
            string expected = "Invalid parameter";

            // Act 
            Exception e = Assert.Throws<ArgumentException>(() => Obiect.Prime(x));
            // Assert
            Assert.Contains(expected,e.Message);
        }
    }
}
