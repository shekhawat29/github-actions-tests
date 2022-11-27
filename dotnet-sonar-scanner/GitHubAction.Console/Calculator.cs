using GitHubAction.ClassLibrary;

namespace GitHubAction.Console;

public class Calculator
{
    private readonly IMathsHelper _good;
    private readonly IMathsHelper _bad;

    public Calculator(IMathsHelper? good, IMathsHelper? bad)
    {
        _good = good ?? new CorrectMaths();
        _bad = bad ?? new WrongMaths();
    }

    public Calculator() : this(null, null)
    { }

    public int GetSum(int a, int b, bool correct = true) => correct
        ? _good.Sum(a, b)
        : _bad.Sum(a, b);
}
