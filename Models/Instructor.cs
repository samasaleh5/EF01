using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public decimal Bouns {  get; set; }
        public decimal Salary { get; set; }
        [Required,MaxLength(255)]
        public string Adress { get; set; }
        public decimal HourRate { get; set; }
        [ForeignKey("Department")]
        public int Dept_ID { get; set; }

    }
}
