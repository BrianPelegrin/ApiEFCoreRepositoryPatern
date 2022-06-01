using System;
using System.Collections.Generic;

namespace ApiEFCoreRepositoryPatern.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public int? AuthorId { get; set; }
        public string? BookName { get; set; }

        public virtual Author? oAuthor { get; set; }
        public virtual Category? oCategory { get; set; }
    }
}
