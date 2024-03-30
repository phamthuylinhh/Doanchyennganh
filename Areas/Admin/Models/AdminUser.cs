﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Areas.Admin.Models
{
    [Table("AdminUser")]
    public class AdminUser
    {
            [Key]
            public int UserId { get; set; }
            public string? UserName { get; set; }
            public string? Password { get; set; }
            public string? Email { get; set; }
            public bool? IsActive { get; set; }
    }
}
