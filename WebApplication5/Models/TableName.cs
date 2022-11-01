using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    [Table("table_name")]
    public partial class TableName
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("login")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Login { get; set; }
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }
        [Column("email")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }
    }
}
