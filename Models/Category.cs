using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required, MaxLength(50)]
        public string? Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
