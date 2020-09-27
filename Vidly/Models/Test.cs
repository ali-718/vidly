using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Test
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Age { get; set; }

        [Required]
        [StringLength(255)]
        public string occupation { get; set; }
    }
}