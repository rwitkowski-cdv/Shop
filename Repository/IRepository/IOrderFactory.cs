using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface IOrderFactory
    {
        OrderDetail CreateOrderDetail(ShoppingCart cart);
        List<OrderDetail> CreateOrderDetails(List<ShoppingCart> shoppingCarts);
    }
}
