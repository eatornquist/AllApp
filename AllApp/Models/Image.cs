using System.ComponentModel.DataAnnotations;

namespace AllApp.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
