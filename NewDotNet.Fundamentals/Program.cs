// See https://aka.ms/new-console-template for more information

using NewDotNet.Fundamentals.Variables;
using NewDotNet.Fundamentals.VariablesAndClasses.Math;

Console.WriteLine("Hello, World!");

Variables.Run();

var person = new Person2()
{
    FistName = "Becca",
    LastName = "Smith"
};
person.Introduce();

Calculator calc = new Calculator();
Console.WriteLine(calc.Add(3, 5));

