

using System.Collections;
using NewDotNet.Intermediate.Section1.Classes;
using NewDotNet.Intermediate.Section1.Classes.accessmodifiers;
using NewDotNet.Intermediate.Section1.Classes.Casting;
using NewDotNet.Intermediate.Section1.Classes.Composition;
using NewDotNet.Intermediate.Section1.Classes.Inheritance;
using NewDotNet.Intermediate.Section2;
using Customer2 = Amazon.Customer;
using Customer = NewDotNet.Intermediate.Section1.Classes.Customer;


Console.WriteLine("Hello from NewDotNet.Intermediate!");

var person = Person.Parse("Becca");
person.Introduce("Alice");

var customer = new Customer();
Console.WriteLine("Customer class fields {0} and {1}", customer.Id, customer.Name);

var order = new Order();
customer.Orders.Add(order);

// wierd code
var a = 2; 
var myClass = new MyClass();
myClass.MyMethod(a);

int number;
var result = int.TryParse("abc", out number);
if (result) Console.WriteLine(number);
else Console.WriteLine("Conversion failed");



static void UseParams()
{
var calculator = new Calculator();
Console.WriteLine(calculator.Add(1, 2));
Console.WriteLine(calculator.Add(1, 2, 3));
Console.WriteLine(calculator.Add(1, 2, 3, 4));
    
}

static void UsePoints()
{
    // Handling an unexpected value
    try
    {
        var point = new Point(10, 20);
        point.Move(null);
        Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
        point.Move(100, 200);
        Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

    }
    catch (Exception e)
    {
        Console.WriteLine("An unexpected error occured: {0}", e.Message);
    } 
}

var customer5 = new Customer();
customer.Orders.Add(new Order());
customer.Orders.Add(new Order());
customer.Promote();
Console.WriteLine(customer.Orders.Count);

 var man = new Person2(new DateTime(1999, 04, 22));
 // man.SetBirthDate(new DateTime(1985, 03, 14));
 // Console.WriteLine(man.GetBirthDate());
 Console.WriteLine(man.BirthDate);
 Console.WriteLine(man.Age);
 
 var cookie =  new HttpCookie();
 cookie["name"] = "Becca";
 Console.WriteLine(cookie["name"]);
 
 var stopWatch = new StopWatch();
 stopWatch.Start();
 for (var i = 0; i < 10; i++)
 {
     Console.WriteLine("Hello {0}, I would like to see how long it takes to run a for loop", i);
 }
 stopWatch.Stop();
 Console.WriteLine("Duration: {0}", stopWatch.Duration);
 
 
 // INHERITANCE
 var text = new Text();
 text.Width = 100;
 text.Copy();
 
 // Composition
 var dbMigrator = new DbMigrator(new Logger());
dbMigrator.Migrate();
 
 var logger = new Logger();
 var installer = new Installer(logger);
 installer.Install();
 
 //
 var customerSpecial = new Customer2();


// base class
var car = new Car("RAD3245");

// Casting
Text2 text2 = new Text2();
Shape2 shape2 = text2;
 text.Width = 200;
 shape2.Width = 100;
 
// upcasting
 // StreamReader reader = new StreamReader(new FileStream("file.txt", FileMode.Open));
 // ArrayList list = new ArrayList();
 // list.Add(1);
 // list.Add("Wierd");
 // list.Add(new Text());
 // Console.WriteLine("An array list can be not safe in C# since it stores data with different types");
 // foreach (var item in list)
 // {
 //     Console.WriteLine(item);
 // }
 // down casting
 Shape2 shape3 = new Text2();
 Text2 text3 = (Text2)shape3;
 
 
 // Modular calculator
 ModularCalculator calculator = new ModularCalculator(10, 0);
 calculator.Addition();
 calculator.Multiplication();
 calculator.Division();
calculator.Subtraction();
