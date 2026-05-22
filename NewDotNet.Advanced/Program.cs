// See https://aka.ms/new-console-template for more information

using NewDotNet.AdvancedC.Delegates;
using NewDotNet.AdvancedC.EventsAndDelegates;
using NewDotNet.AdvancedC.Generics;
using NewDotNet.AdvancedC.LambdaExpressions;

Console.WriteLine("Hello, World!");


// Generics
var book = new Book {Isbn = "1111", Title = "C# Advanced"};

var numbers = new GenericList<int>();
numbers.Add(1);

var books = new GenericList<Book>();
books.Add(new Book {Isbn = "1121", Title = "C# Intermediate"});

var dictionary = new GenericDictionary<string, Book>();
dictionary.Add("1", new Book {Isbn = "1131", Title = "C# Basics"});

var number = new Nullable2<int>(5);
Console.WriteLine("Has value? " + number.HasValue);
Console.WriteLine("Value: " + number.GetValueOrDefault());


// Delegates
var photoProcessor = new PhotoProcessor();
var filters = new PhotoFilters();
var filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += RemoveRedEyeFilters;

photoProcessor.Process("photo.jpg", filterHandler);

static void RemoveRedEyeFilters(Photo photo)
{
    Console.WriteLine("apply remove red eye");
}

// Examples: System.Action<> points to a method that returns void while System.Func<> points to a method that returns a value.

// Lambda expressions
 Squaring.Square(5);
 
 // args => expression
 // num => num * num;

// () => ...
 Func<int, int> square = num => num * num;
 const int factor = 6;
 Func<int, int> multiplier =  num => num * factor;
 
 
 var books2 = new BookRepository().GetBooks();
 var cheapBooks = books2.FindAll(book2 => book2.Price < 10);
 foreach (var book2 in cheapBooks)
 {
     Console.WriteLine(book2.Title);
 }
 
 // Events and delegates
var video = new Video {Title = "C# Advanced"};
var videoEncoder = new VideoEncoder(); // publisher
var mailService = new MailService(); // Subscriber
videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.Encode(video);