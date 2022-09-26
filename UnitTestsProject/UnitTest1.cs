using DecoderPrintLiteLibs.Models;
namespace UnitTestsProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(3, "Январь", "Врегуя")]
    [TestCase(32, "Вальгалла","Бякывяккя")]
    [TestCase(9, "Транквилизатор", "Ыщицуксфсриычщ")]
    public void CaesarEncodingTest(int key, string originMessage, string expectedMessage)
    {
        // Arrange
        CaesarAlgorithm<int> alg = new CaesarAlgorithm<int>(key);
        // Act
        string actualMessage = alg.Encoding(originMessage);
        // Assert
        Assert.That(actualMessage==expectedMessage, $"Error! Result: {actualMessage}");
        // Log
        NUnit.Framework.TestContext.Progress.WriteLine($"\nUT[CaesarEncodingTest]\nResult: {actualMessage}");
    }

    [TestCase(3, "Врегуя", "Январь")]
    [TestCase(1, "Наш","Мяч")]
    [TestCase(32, "ЮпыъбитЙъубыие", "ЯрьывйуКыфвьйё")]    
    public void CaesarDecodingTest(int key, string encodingMessage, string expectedMessage)
    {
        // Arrange
        CaesarAlgorithm<int> alg = new CaesarAlgorithm<int>(key);
        // Act
        string actualMessage = alg.Decoding(encodingMessage);
        // Assert
        Assert.That(actualMessage==expectedMessage, $"Error! Result: {actualMessage}");
        // Log
        NUnit.Framework.TestContext.Progress.WriteLine($"\nUT[CaesarDecodingTest]\nResult: {actualMessage}");        
    }

}