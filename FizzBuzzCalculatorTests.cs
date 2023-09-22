using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwistedFizzBuzz;

[TestClass]
public class FizzBuzzCalculatorTests
{
    [TestMethod]
    public void CalculateFizzBuzz_WithSingleNumbers_ShouldReturnCorrectResults()
    {
        // Arrange
        string input = "1, 2, 3, 4, 5";

        // Act
        List<string> results = FizzBuzzCalculator.CalculateFizzBuzz(input);

        // Assert
        CollectionAssert.AreEqual(new[] { "1", "2", "Fizz", "4", "Buzz" }, results);
    }

    [TestMethod]
    public void CalculateFizzBuzz_WithRange_ShouldReturnCorrectResults()
    {
        // Arrange
        string input = "1-5";

        // Act
        List<string> results = FizzBuzzCalculator.CalculateFizzBuzz(input);

        // Assert
        CollectionAssert.AreEqual(new[] { "1", "2", "Fizz", "4", "Buzz" }, results);
    }

    [TestMethod]
    public void CalculateFizzBuzz_WithInvalidInput_ShouldReturnErrorMessage()
    {
        // Arrange
        string input = "1, 2, A, 4, 5";

        // Act
        List<string> results = FizzBuzzCalculator.CalculateFizzBuzz(input);

        // Assert
        CollectionAssert.AreEqual(new[] { "1", "2", "A: Invalid input (not an integer)", "4", "5" }, results);
    }
}
