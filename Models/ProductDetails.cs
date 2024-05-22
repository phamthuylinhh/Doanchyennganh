using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Doan.Models
{
    [Table("ProductDetails")]
    public class ProductDetails
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Products")]
        public int Products_id { get; set; }
        [ForeignKey("Size")]
        public int Size_id { get; set; }
        public int Quantity { get; set; }
    }
}
