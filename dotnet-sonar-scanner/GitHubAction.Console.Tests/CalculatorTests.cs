using GitHubAction.ClassLibrary;
using Moq;

namespace GitHubAction.Console.Tests;

public class CalculatorTests
{
    private readonly Mock<IMathsHelper> _goodMathsMock = new();
    private readonly Mock<IMathsHelper> _badMathsMock = new();

    private Calculator _calculator = null!;

    [SetUp]
    public void BeforeEach()
    {
        _badMathsMock.Reset();
        _goodMathsMock.Reset();

        _calculator = new Calculator(_goodMathsMock.Object, _badMathsMock.Object);
    }

    [Test]
    public void GetSum_CorrectIsTrue_UsesGoodMaths()
    {
        _goodMathsMock.Setup(m => m.Sum(It.IsAny<int>(), It.IsAny<int>()))
            .Returns(15);

        var actual = _calculator.GetSum(1, 2);

        _goodMathsMock.Verify(m => m.Sum(1, 2));
        Assert.That(actual, Is.EqualTo(15));
    }

    [Test]
    public void GetSum_CorrectIsFalse_UsesBadMaths()
    {
        _badMathsMock.Setup(m => m.Sum(It.IsAny<int>(), It.IsAny<int>()))
            .Returns(123);

        var actual = _calculator.GetSum(1, 2, false);

        _badMathsMock.Verify(m => m.Sum(1, 2));
        Assert.That(actual, Is.EqualTo(123));
    }
}
