using System.ComponentModel.DataAnnotations;

namespace ДЗ_21._Валідація_і_кешування
{
    public class Group
    {
        public int Id { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 2)]
        [RegularExpression(@"\w{3}\d{2}")]
        public string Name { get; set; }
        [Range(0,7)]
        public int Course { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
