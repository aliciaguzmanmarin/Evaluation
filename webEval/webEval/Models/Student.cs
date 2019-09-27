using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webEval.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Birthday { get; set; }

        public virtual ICollection<Note> Note { get; set; }
    }
}