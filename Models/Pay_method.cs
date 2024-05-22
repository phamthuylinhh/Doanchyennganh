using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Doan.Models
{
	[Table("Pay_method")]
	public class Pay_method
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
	}
}
