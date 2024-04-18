using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Doan.Models
{
    [Table ("Category")]
    public class Category
    {
        [Key]   
        public int id { get; set; }
        public string? Name { get; set; }
    }
}
