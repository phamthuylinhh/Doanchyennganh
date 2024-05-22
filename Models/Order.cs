using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Doan.Models
{
	[Table("Order")]
	[PrimaryKey(nameof(Id),nameof(ProductID),nameof(ProductSizeID))]
	public class Order
    {
        public Order() { Created_at = DateTime.Now; }
		public string Id { get; set; }
		public int User_id { get; set; }
		public string Address { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public int Pay_method_id { get; set; }
		public DateTime Created_at { get; set; }
		public string? Oder_status { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public int ProductID { get; set; }
        public int ProductSizeID { get; set; }
    }
}
