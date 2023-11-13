using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {

        [TestMethod]
        [DataRow("FIZZBUZZ", 15)]
        [DataRow("FIZZ", 6)]
        [DataRow("BUZZ", 25)]
        public void FizzBuzzKalkyl_ReturnsExpectedResult(string expectedResult, int randomNummer)
        {
            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}