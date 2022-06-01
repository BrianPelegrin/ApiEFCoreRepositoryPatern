using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("owner")]
    public class Books
    {
        public Guid BooksId { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [StringLength(50, ErrorMessage ="El debe tener como maximo 50 caracteres")]
        public string? name { get; set; }

        public string? description { get; set; }
        
        
    }
}
