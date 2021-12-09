using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Ang.Repository.Models
{
    public partial class Student
    {
        [Key]
        [StringLength(30)]
        public string FullName { get; set; }
        public int? Age { get; set; }
        public double? AverageGrade { get; set; }
    }
}
