using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Repository
{
    public class OrderFactory : IOrderFactory
    {
        public OrderDetail CreateOrderDetail(ShoppingCart cart)
        {
            if (cart == null) throw new ArgumentNullException(nameof(cart));

            return new OrderDetail
            {
                CreatedOn = DateTime.UtcNow,
                CreatedById = Guid.Parse(cart.UserId),
                ProductId = cart.ProductId,
                Count = cart.Quantity,
                TotalPrice = Convert.ToDouble(cart.Product.NetAmount),
                Name = cart.Product.Name 
            };
        }

        public List<OrderDetail> CreateOrderDetails(List<ShoppingCart> shoppingCarts)
        {
            return shoppingCarts?.Select(CreateOrderDetail).ToList() ?? new List<OrderDetail>();
        }
    }
}
