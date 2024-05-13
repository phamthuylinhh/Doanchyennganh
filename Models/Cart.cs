using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Models
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int Cart_id { get; set; }
        public int User_id { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public int? Price { get; set; }
        public string? Order_status { get; set; }
    }
}
