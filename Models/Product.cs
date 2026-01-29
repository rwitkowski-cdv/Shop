using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? SKU { get; set; }
        public string? ImageUrl { get; set; }
        [Range(0.01, 1000)]
        public decimal GrossAmount { get; set; }
        [Range(0.01, 1000)]
        public decimal NetAmount { get; set; }
        [Range(0.01, 1000)]
        public decimal TaxAmount { get; set; }
        public string? Description { get; set; }
        public bool IsAvailable { get; set; }
        public string? Tag { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
