using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Models
{
	[Table("NewArrivals")]
	public class NewArrivals
	{
		[Key]
		public int Id { get; set; }
		public string? Title { get; set;}
		public string? Contents { get; set; }
		public int ParentID { get; set; }
		public string? Image { get; set; }
	}
}
