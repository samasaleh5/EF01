using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Name { get; set; }
    }
}
