namespace GitHubAction.ClassLibrary.Tests;

public class CorrectMathsTests
{
    private readonly CorrectMaths _implementation = new();
    private IMathsHelper Helper => _implementation;

    [Test]
    [TestCase(1, 2, 3)]
    [TestCase(2, 3, 5)]
    [TestCase(11, 22, 33)]
    public void Sum(int a, int b, int expected)
    {
        var actual = Helper.Sum(a, b);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
