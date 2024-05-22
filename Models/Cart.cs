using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Models
{
    [Table("Cart")]
    [PrimaryKey(nameof(User_id), nameof(Product_id), nameof(Size_id))]
    public class Cart
    {
        public int User_id { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public int? Price { get; set; }
        public int Size_id { get; set; }
    }
}
