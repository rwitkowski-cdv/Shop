using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category : BaseModel
    {
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
