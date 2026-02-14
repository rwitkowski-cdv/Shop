using Shop.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class ShoppingCart : BaseModel
    {
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public override string GetDisplayName() => $"Shopping Cart Item: {Id}";
    }
}
