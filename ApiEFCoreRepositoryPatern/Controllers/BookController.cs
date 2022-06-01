using ApiEFCoreRepositoryPatern.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiEFCoreRepositoryPatern.Models;
using ApiEFCoreRepositoryPatern.Models.DTO;

namespace ApiEFCoreRepositoryPatern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IDataRepository<Book, BookDTO> _repository;

        public BookController(IDataRepository<Book, BookDTO> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var books = _repository.GetAll();  
            return Ok(books);
        }

        
    }
}
