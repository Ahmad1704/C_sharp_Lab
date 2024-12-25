using Day04;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book("978-3-16-148410-0", "Book A", new[] { "Author A", "Author B" }, new DateTime(2020, 1, 1), 29.99m),
            new Book("978-1-23-456789-0", "Book B", new[] { "Author C" }, new DateTime(2021, 5, 15), 19.99m)
        };

        GeneralDel<Book,string> del;
        del  = BookFunctions.GetTitle;

       
        Func<Book, string> fPtrBcl = BookFunctions.GetAuthors;

    
        Func<Book, string> fPtrAnonymous = delegate (Book B)
        {
            return B.ISBN;
        };

       
        Func<Book, string> fPtrLambda = (Book B) => B.PublicationDate.ToShortDateString();

      
        Console.WriteLine("Get Title:");
        LibraryEngine.ProcessBooks(books, del);

        Console.WriteLine("\nGet Authors (BCL):");
        LibraryEngine.ProcessBooks(books, fPtrBcl);

        Console.WriteLine("\nGet ISBN (Anonymous Method):");
        LibraryEngine.ProcessBooks(books, fPtrAnonymous);

        Console.WriteLine("\nGet Publication Date (Lambda Expression):");
        LibraryEngine.ProcessBooks(books, fPtrLambda);
    }
}
