using FizzBuzz;

namespace FizzBuzz_Test
{
    

    [TestClass]
    public class KalkylatorTests
    {
        [TestMethod]
        public void When_FizzBuzzKalkyl_15_RETURN_FIZZBUZZ()
        {
            // Arrange
            int randomNummer = 15;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("FIZZBUZZ", result);
        }
        
        [TestMethod]
        public void When_FizzBuzzKalkyl_9_RETURN_FIZZ()
        {
            // Arrange
            int randomNummer = 9;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("FIZZ", result);
        }
        
        [TestMethod]
        public void When_FizzBuzzKalkyl_10_RETURN_BUZZ()
        {
            // Arrange
            int randomNummer = 10;

            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            // Assert
            Assert.AreEqual("BUZZ", result);
        }


        [TestMethod]
        [DynamicData(nameof(FizzBuzzTestCases_1_20), DynamicDataSourceType.Method)]
        public void FizzBuzzKalkyl_ReturnsExpectedResult(string expectedResult, int randomNummer)
        {
            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            Console.WriteLine($"{randomNummer}  =>  {expectedResult}");

            // Assert
            Assert.AreEqual(expectedResult, result);

        }

        public static IEnumerable<object[]> FizzBuzzTestCases_1_20()
        {
            return Enumerable.Range(1, 20)
                .Select(i => new object[] { Kalkylator.FizzBuzzKalkyl(i), i });
        }


    }
}