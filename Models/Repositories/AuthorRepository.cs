using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Author>
    {
         IList<Author> Authors;
        public AuthorRepository()
        {
            Authors = new List<Author>
            {
                new Author{Id=1,FullName="author 1"},
                new Author{Id=2,FullName="author 2"},
                new Author{Id=3,FullName="author 3"}
            };
        } 

        public void Add(Author t)
        {
            Authors.Add(t);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            Authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = Authors.SingleOrDefault(b => b.Id == id);
            return author;
        }

        public IList<Author> FindAll()
        {
            return Authors;
        }

        public void Update(int id, Author t)
        {
            var author = Find(id);
            author.FullName = t.FullName;

        }
    }
}
