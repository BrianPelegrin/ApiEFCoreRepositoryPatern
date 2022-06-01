namespace ApiEFCoreRepositoryPatern.Models.DTO
{
    public class BookDTO
    {
        public BookDTO()
        {

        }

        public int BookId { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public int? AuthorId { get; set; }
        public string? BookName { get; set; }
    }
}
