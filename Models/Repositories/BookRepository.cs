using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        IList<Book> books;
        public BookRepository()
        {
            books = new List<Book>() {
             new Book {
                Id = 1,
                Title = "C# Programming",
                Description="no Description"
             },   new Book {
                Id = 2,
                Title = "Java Programming",
                Description="no Description"
             },   new Book {
                Id = 3,
                Title = "Python Programming",
                Description="no Description"
             }

            };
        }  
                
                
            
        public void Add(Book t)
        {
            books.Add(t);
        }

        public void Delete(int id)
        {
            var book =Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
             var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> FindAll()
        {
            return books;
        }

        public void Update(int id,Book t)
        {
            var book = Find(id);
            book.Title = t.Title;
            book.Description = t.Description;
            book.Author = t.Author;

        }
    }
}
