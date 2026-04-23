

using NewDotNet.Intermediate.Section1.Classes;
using NewDotNet.Intermediate.Section1.Classes.accessmodifiers;

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