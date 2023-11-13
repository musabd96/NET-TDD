using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
       
        public void När_FizzBuzzKalkyl_FIZZBUZZ()
        {
            // Arrange
            int randomNummer = 15;

            // Act
           string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("FIZZBUZZ", result);
        }

        [TestMethod]
        public void När_FizzBuzzKalkyl_FIZZ()
        {
            // Arrange
            int randomNummer = 6;

            // Act
           string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("FIZZ", result);
        }

        [TestMethod]
        public void När_FizzBuzzKalkyl_BUZZ()
        {
            // Arrange
            int randomNummer = 25;

            // Act
           string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("BUZZ", result);
        }
    }
}