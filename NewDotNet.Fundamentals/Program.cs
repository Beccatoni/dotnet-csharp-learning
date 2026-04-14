// See https://aka.ms/new-console-template for more information

using NewDotNet.Fundamentals.DateTimeLearning;
using NewDotNet.Fundamentals.Non_primitives;
using NewDotNet.Fundamentals.StringsLearn;
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

EnumDeclaration  enumDeclaration = new EnumDeclaration();
enumDeclaration.Enums();

ValueAndReferenceTypes valueAndReferenceTypes = new ValueAndReferenceTypes();
valueAndReferenceTypes.Run();

Dates datetime = new Dates();
datetime.Run();

Strings strings = new Strings();
strings.Run();

