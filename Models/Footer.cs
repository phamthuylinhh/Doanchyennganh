using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Models
{
	[Table ("Footer")]
	public class Footer
	{
		[Key]
		public int Id { get; set; }
		//public string? QYTHIRST { get; set; }
		//public string? Menu { get; set; }
		//public string? Help1 { get; set; }
		//public string? Have_a_Questions { get; set; }
		//public string? Icon { get; set; }
		//public string? Help2 { get; set; }
		//public string? Title { get; set; }
		public string? Title { get; set; }
		public string? Contents { get; set; }

	}
}
