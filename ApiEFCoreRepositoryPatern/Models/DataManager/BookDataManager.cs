using ApiEFCoreRepositoryPatern.Interfaces;
using ApiEFCoreRepositoryPatern.Models;
using ApiEFCoreRepositoryPatern.Models.DataManager;
using ApiEFCoreRepositoryPatern.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiEFCoreRepositoryPatern.Models.DataManager
{
    //Creacion del la Clase DataManager
    //esta es la clase de las cuales heredaran los controladores para poder implementar
    //la interfaz Repository dentro de "<>" Ira el nombre del modelo o entintidad y luego
    //el nombre del DTO o View Model
    public class BookDataManager : IDataRepository<Book, BookDTO>
    {
        //Aqui Creamos la variable para almacenar el contrexto para realizar las operaciones CRUD
        private readonly DBLibraryContext _context;

        //Creamos el Constructor para pasarle el contexto a la variable antes creada
        public BookDataManager(DBLibraryContext context)
        {
            _context = context;
        }

        //Aqui estan los metodos de la interfaz Implementada

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
            _context.ChangeTracker.LazyLoadingEnabled = true;

            using(var context = new DBLibraryContext())
            {
                var book = context.Books.SingleOrDefault(a => a.BookId == id);
                //aqui le pasamos la entidad que vamos a mapear para que la devuelva

                return BookDTOMapper.MapToDTO(book);
            }
        }

        public void Update(Book entity)
        {
            _context.Books.Update(entity);
            _context.SaveChanges();
        }
    }
}
