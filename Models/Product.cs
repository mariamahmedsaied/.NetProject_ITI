using System.ComponentModel.DataAnnotations;

namespace SchoolLibraryStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required, MaxLength(100)]
        public string? Title { get; set; }

        [Required, Range(0.01, 10000)]
        public decimal Price { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required, Range(0, 1000)]
        public int Quantity { get; set; }

        public string? ImagePath { get; set; }

        
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
