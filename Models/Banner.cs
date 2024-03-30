using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Doan.Models
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Images { get; set;}
    }
}
