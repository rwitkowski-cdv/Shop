using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface IOrderRepository
    {
        public Task<OrderHeader> CreateAsync(OrderHeader orderHeader);
        public Task<OrderHeader> GetAsync(Guid id);
        public Task<IEnumerable<OrderHeader>> GetAllAsync(string? userId = null);
        public Task<OrderHeader> UpdateStatusAsync(Guid orderId, string status, string userId);
    }
}
