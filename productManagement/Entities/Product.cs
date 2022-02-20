using System.ComponentModel.DataAnnotations;

namespace productManagement.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public bool Available { get; set; }
        public string? Description { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
    }
}
