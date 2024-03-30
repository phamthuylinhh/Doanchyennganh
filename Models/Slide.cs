using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Doan.Models
{
	[Table("Slide")]
	public class Slide
	{
		[Key]
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Contents { get; set; }
		public string? Images { get; set; }
		public bool? IsActive { get; set; }
	}
}
