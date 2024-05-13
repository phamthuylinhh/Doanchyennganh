using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Models
{
	[Table("NewArrivals")]
	public class NewArrivals
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set;}
		public string? Contents { get; set; }
		public int ParentID { get; set; }
		public string? Image { get; set; }
		public int? Price { get; set; }
	}
}
