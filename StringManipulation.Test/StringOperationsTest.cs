using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            // Arrange
            // Se crea un objeto de la clase que se va a probar.
            StringOperations strOperations = new();

            // Act
            // Se guarda en una variable el resultado del método que se va a probar
            var result = strOperations.ConcatenateStrings("Hello", "Platzi");

            // Assert
            // Con esta función se comprueba que el código devuelva lo que debe devolver.
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello Platzi", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            //Arrange
            StringOperations strOperations = new();

            //Act
            bool result = strOperations.IsPalindrome("ama");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            //Arrange
            StringOperations strOperations = new();

            //Act
            bool result = strOperations.IsPalindrome("hello");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.QuantintyInWords("cat", 10);

            //Assert
            Assert.StartsWith("diez", result);
            Assert.Contains("cat", result);

        }

        [Fact]
        public void GetStringLength_Exception()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => strOperations.GetStringLength(null));
        }

        [Theory]
        [InlineData("V",5)]
        [InlineData("III", 3)]
        [InlineData("X", 10)]
        [InlineData("XIII", 13)]
        [InlineData("XIX", 19)]
        [InlineData("L", 50)]
        [InlineData("MMXVIII", 2018)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            //Arrange
            StringOperations strOperations = new();

            //Act
            var result = strOperations.FromRomanToNumber(romanNumber);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(Skip = "Esta prueba no es valida en este momento")]
        public void ConcatenateStrings_SKIP()
        {
            // Arrange
            // Se crea un objeto de la clase que se va a probar.
            StringOperations strOperations = new();

            // Act
            // Se guarda en una variable el resultado del método que se va a probar
            var result = strOperations.ConcatenateStrings("Hello", "Platzi");

            // Assert
            // Con esta función se comprueba que el código devuelva lo que debe devolver.
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello Platzi", result);
        }

        [Fact]
        public void CountOccurrences()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<StringOperations>>();
            StringOperations strOperations = new(mockLogger.Object);
            
            // Act
            var result = strOperations.CountOccurrences("Hello platzi", 'l');

            // Assert
            Assert.Equal(3, result);
        }
    }
}
