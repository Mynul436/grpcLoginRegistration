using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace grpc_db_ops.Repository.Models
{
    [Table("RegLog_tbl")]
    public partial class RegLogTbl
    {
        [Column("Student Name")]
        [StringLength(50)]
        public string StudentName { get; set; } = null!;
        [Key]
        [Column("StudentID")]
        public int StudentId { get; set; }
    }
}
