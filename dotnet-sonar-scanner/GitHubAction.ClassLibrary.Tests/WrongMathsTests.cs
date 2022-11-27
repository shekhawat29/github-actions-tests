namespace GitHubAction.ClassLibrary.Tests;

public class WrongMathsTests
{
    private readonly WrongMaths _implementation = new();
    private IMathsHelper Helper => _implementation;

    [Test]
    [TestCase(1, 2, -1)]
    [TestCase(5, 3, 2)]
    [TestCase(33, 22, 11)]
    public void Sum(int a, int b, int expected)
    {
        var actual = Helper.Sum(a, b);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
