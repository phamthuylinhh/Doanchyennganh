using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Models
{
	[Table("Dealoftheweek")]
	public class Dealoftheweek
	{
		[Key]	
		public int Id { get; set; }
		public string? Images { get; set; }
	}
}
