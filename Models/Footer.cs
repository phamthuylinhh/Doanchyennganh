﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Models
{
	[Table ("Footer")]
	public class Footer
	{
		[Key]
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Contents { get; set; }

	}
}
