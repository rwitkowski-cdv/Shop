using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Category name cannot be empty.")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
