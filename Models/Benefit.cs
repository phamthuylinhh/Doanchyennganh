using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Doan.Models
{
    [Table ("Benefit")]
    public class Benefit
    {
        [Key]
        public int Id { get; set; }
        public string?  Title { get; set; }
        public string? Contents{ get; set; }
        public string? Icon { get; set; }
    }
}
