using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            // Se crea un objeto de la clase que se va a probar.
            StringOperations strOperations = new();

            // Se guarda en una variable el resultado del método que se va a probar
            var result = strOperations.ConcatenateStrings("Hello", "Platzi");

            // Con esta función se comprueba que el código devuelva lo que debe devolver.
            Assert.Equal("Hello Platzi", result);
        }

    }
}
