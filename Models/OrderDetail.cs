using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class OrderDetail : BaseModel
    {
        public Guid OrderHeaderId { get; set; }
        public OrderHeader OrderHeader { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        [Display(Name = "Total Price")]
        public double TotalPrice { get; set; }

        public override string GetDisplayName() => $"Order Name: {Id}";

    }
}
