using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Doan.Models
{
    [Table ("Products")]
    public class Products
    {
        [Key]
      public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Category")]
        public int Category_id { get; set; }
        public string? Title { get; set; }
        public string? Contents { get; set; }
        public string? Images { get; set; }
        public int? Price { get; set; }
        public string? Link { get; set; }
     

        
    }
}
