// See https://aka.ms/new-console-template for more information

using NewDotNet.Fundamentals.Variables;

Console.WriteLine("Hello, World!");

Variables.Run();

var person = new Person2()
{
    FistName = "Becca",
    LastName = "Smith"
};
person.Introduce();
