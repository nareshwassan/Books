using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    [Table("books")]
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        public string BookName{ get; set; }
    }
}
