using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yearn.modules.domainobjects
{
    [Table("student")]
    public class Student
    {
        [Column("student_id")]
        [Required]
        public int Id { get; set; }

        [Column("student_number")]
        [Required]
        public long StudentNumber { get; set; }

        [Column("last_name")]
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Column("first_name")]
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
    }
}