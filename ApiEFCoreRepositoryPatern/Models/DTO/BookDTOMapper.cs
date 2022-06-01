using ApiEFCoreRepositoryPatern.Models;
namespace ApiEFCoreRepositoryPatern.Models.DTO
{

    //Creacion de la Clase que mapea el Json de que recibe el controlador
    public class BookDTOMapper
    {
        //Creamos el metodo que recibira un modelo
        public static BookDTO MapToDTO(Book? book)
        {
            if (book == null)
            {
                return null;
            }
            //retornamos un el json formado por el objeto BookDTO para mostrar sus propiedass

            return new BookDTO()
            {
                BookId = book.BookId,
                BookName = book.BookName,
                Description = book.Description,
                //Aqui va una representacion de la tabla author creada en el DTO
                //de la clase book
                authorDto = new AuthorDTO()
                {
                    //el Id del la clase Author va a ser igual al Id del modelo que pasamos
                    Id = book.BookId,
                    AuthorName = book.BookName,

                }
            };
        }


    }
}
