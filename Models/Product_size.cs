using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Models
{
	[Table("Product_size")]
	public class Product_size
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
