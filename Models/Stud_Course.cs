using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    public class Stud_Course
    {
        
        public int stud_ID { get; set; }
      
        public int Course_ID {  get; set; }
        [Required,MaxLength(2)]
        public string Grade { get; set; }
    }
}
