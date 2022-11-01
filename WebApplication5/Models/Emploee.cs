using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    [Keyless]
    [Table("Emploee", Schema = "TBL")]
    public partial class Emploee
    {
        [Column("ID_Employee")]
        public int IdEmployee { get; set; }
        [Column("First_Name")]
        [StringLength(30)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [Column("Second_Name")]
        [StringLength(30)]
        [Unicode(false)]
        public string SecondName { get; set; } = null!;
        [Column("Middle_Name")]
        [StringLength(30)]
        [Unicode(false)]
        public string? MiddleName { get; set; }
        [Column("Employee_Phone")]
        [StringLength(17)]
        [Unicode(false)]
        public string EmployeePhone { get; set; } = null!;
        [Column("Employee_E_Mail")]
        [Unicode(false)]
        public string? EmployeeEMail { get; set; }
        public int? Salary { get; set; }
    }
}
