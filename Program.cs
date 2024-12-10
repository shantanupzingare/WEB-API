using EntityCRUD.Models;
using EntityCRUD.Services;
using System.Security.Cryptography.X509Certificates;

namespace EntityCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ServiceBook serviceBook = new ServiceBook();
            //serviceBook.Addmany();
            //var book = new Book
            //{

            //    Title = "let us C",
            //    AuthorId = 1


            //};
            //serviceBook.AddBook(book);
            //var x = serviceBook.Display();
            //foreach (var item in x)
            //{
            //    Console.WriteLine($"{item.AuthorId} {item.Title} {item.Author.FirstName} {item.Author.LastName}");
            //}
            //var bookup = new Book
            //{
            //    Title = "Title your skill",
            //    BookId = 4,
            //    AuthorId = 2
            //};
            //serviceBook.RemoveBook(6);
            serviceBook.DeleteAuth(6);
            var b1 = serviceBook.Display();
            foreach(var item in b1)
            {
                Console.WriteLine($"{item.BookId} {item.Title} {item.Author.FirstName} {item.Author.LastName}");
            }
        }
    }
}
