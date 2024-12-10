using EntityCRUD.Models;
using EntityCRUD.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCRUD.Services
{
    internal class ServiceBook
    {
        private readonly SampleContext db;
        public ServiceBook()
        {
            db = new SampleContext();
        }
        public void Addmany()
        {
            var auther = new Author
            {
                FirstName = "William",
                LastName = "Shakespeare",
                Books = new List<Book>
                {
                    new Book{Title="Hamlet"},
                    new Book{Title="Othello"},
                    new Book{Title="MacBeth" }
                }
            };
            db.Add(auther);
            db.SaveChanges();
        }
        public void AddBook(Book obj)
        {
            db.Add(obj);
            db.SaveChanges();
        }
        public IEnumerable<Book> Display()
        {
            return db.Books.Include((a) => a.Author).ToList<Book>();
        }
        public void UpdateBook(Book obj)
        {
            SampleContext db1 = new SampleContext();
            db1.Update(obj);
            db1.SaveChanges();
        }
        public void RemoveBook(int id)
        {
            Book book = db.Books.FirstOrDefault(x => x.BookId == id);
            if (book != null)
            {
                db.Remove(book);
                db.SaveChanges();
            }

        }
        public void Display(string title)
        {
            FormattableString sql = $"select * from Books where title={title}";
            //var book = db.Books.FromSql(sql).FirstOrDefault();
            //Console.WriteLine(book.Title);
            var books = db.Books.FromSql($"Execute dbo.GetMostPopularBooks{title}").ToList();
            foreach (var sd in books)
            {
                Console.WriteLine(sd.Title);
            }
        }
        public void DeleteAuth(int id)
        {
            var auth = new Author { AutherId = id };
            db.Remove(auth);
            db.SaveChanges();
        }
    }
}
