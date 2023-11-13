using FizzBuzz;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzz_Test
{
    [TestClass]
    public class KalkylatorTests
    {

        [TestMethod]
        [DynamicData(nameof(FizzBuzzTestCases), DynamicDataSourceType.Method)]
        public void FizzBuzzKalkyl_ReturnsExpectedResult(string expectedResult, int randomNummer)
        {
            // Act
            string result = Kalkylator.FizzBuzzKalkyl(randomNummer);

            Console.WriteLine($"{randomNummer}  =>  {expectedResult}");

            // Assert
            Assert.AreEqual(expectedResult, result);

        }

        public static IEnumerable<object[]> FizzBuzzTestCases()
        {
            return Enumerable.Range(1, 20)
                .Select(i => new object[] { Kalkylator.FizzBuzzKalkyl(i), i });
        }


    }
}