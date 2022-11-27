// See https://aka.ms/new-console-template for more information

using GitHubAction.Console;

var calc = new Calculator();

Console.WriteLine($"Hello, World! 2 + 2 = {calc.GetSum(2, 2)}");
