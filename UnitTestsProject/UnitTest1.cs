using DecoderPrintLiteLibs.Models;
namespace UnitTestsProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Январь", "Врегуя")]
    [TestCase("Вальгалла","Егояёгоог")]
    public void CaesarTest(string originMessage, string expectedMessage)
    {
        // Arrange
        CaesarAlgorithm<int> alg = new CaesarAlgorithm<int>(3);
        // Act
        string actualMessage = alg.Encoding(originMessage);
        // Assert
        Assert.That(actualMessage==expectedMessage, $"Error! Result: {actualMessage}");
        // Log
        //NUnit.Framework.TestContext.Progress.WriteLine($"\nUT[CaesarTest]\nResult: {actualMessage}");
    }

}