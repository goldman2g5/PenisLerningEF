using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    [Table("Item", Schema = "TBL")]
    [Index("Name", Name = "Item_Name_uindex", IsUnique = true)]
    [Index("Id", Name = "Item_id_uindex", IsUnique = true)]
    public partial class Item
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Name { get; set; }
        public int? Price { get; set; }
    }
}
