namespace GitHubAction.ClassLibrary;

public interface IMathsHelper
{
    int Sum(int a, int b);
}

public class CorrectMaths : IMathsHelper
{
    public int Sum(int a, int b) => a + b;
}

public class WrongMaths : IMathsHelper
{
    public int Sum(int a, int b) => a - b;
}
