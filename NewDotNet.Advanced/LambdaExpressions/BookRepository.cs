using NewDotNet.AdvancedC.Generics;

namespace NewDotNet.AdvancedC.LambdaExpressions;

public class BookRepository
{
    public List<Book> GetBooks()
    {
        return
        [
            new Book { Title = "Title1", Price = 3, Isbn = "1234567890" },
            new Book { Title = "Title2", Price = 9, Isbn = "0987654321" },
            new Book { Title = "Title3", Price = 35, Isbn = "1122334455" },
            new Book { Title = "Title4", Price = 8, Isbn = "5566778899" },
            new Book { Title = "Title5", Price = 25, Isbn = "6677889900" }
        ];
    }
}