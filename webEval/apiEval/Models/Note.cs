

namespace apiEval.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum TypeSubject
    {
        Math,
        History,
        Art,
    }

    public enum TypeNote
    {
        Aprobado,
        Reprobado,
    }
    public class Note
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Nota { get; set; }
        [Required]
        public TypeSubject Subject { get; set; }
        [Required]
        public TypeNote Estado { get; set; }

        public Student Estudiante { get; set; }

    }
}