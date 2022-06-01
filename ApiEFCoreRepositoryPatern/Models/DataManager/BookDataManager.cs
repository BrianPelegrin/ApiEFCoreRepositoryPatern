using ApiEFCoreRepositoryPatern.Interfaces;
using ApiEFCoreRepositoryPatern.Models;
using ApiEFCoreRepositoryPatern.Models.DataManager;
using ApiEFCoreRepositoryPatern.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiEFCoreRepositoryPatern.Models.DataManager
{
    public class BookDataManager : IDataRepository<Book, BookDTO>
    {
        private readonly DBLibraryContext _context;

        public BookDataManager(DBLibraryContext context)
        {
            _context = context;
        }

        public void Add(Book entity)
        {

            _context.Books.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Book entity)
        {
            
            _context.Books.Remove(entity);
            _context.SaveChanges();

        }

        public Book Get(long id)
        {
            
            var book = _context.Books.Find(id);
            
            return book;
        }

        public IEnumerable<Book> GetAll()
        {
            var book = _context.Books.Include(book => book.oAuthor).Include(book => book.oCategory).ToList();
            return book;
        }

        public BookDTO GetDto(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            _context.Books.Update(entity);
            _context.SaveChanges();
        }
    }
}
