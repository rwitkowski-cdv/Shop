using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OrderHeader> CreateAsync(OrderHeader orderHeader)
        {
            orderHeader.CreatedOn = DateTime.UtcNow;
            orderHeader.CreatedById = Guid.Parse(orderHeader.UserId);
            orderHeader.OrderDate = DateTime.UtcNow;
            await _dbContext.OrderHeader.AddAsync(orderHeader);
            await _dbContext.SaveChangesAsync();
            return orderHeader;
        }

        public async Task<IEnumerable<OrderHeader>> GetAllAsync(string? userId = null)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                return await _dbContext.OrderHeader.Where(u => u.UserId == userId).ToListAsync();
            }
            return await _dbContext.OrderHeader.ToListAsync();
        }

        public async Task<OrderHeader> GetAsync(Guid id)
        {
            return await _dbContext.OrderHeader.Include(u => u.OrderDetails).FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<OrderHeader> UpdateStatusAsync(Guid orderId, string status, string userId)
        {
            var orderHeader = _dbContext.OrderHeader.FirstOrDefault(u => u.Id == orderId);
            if (orderHeader != null)
            {
                orderHeader.ModifiedOn = DateTime.UtcNow;
                orderHeader.ModifiedById = Guid.Parse(userId);
                orderHeader.Status = status;
                await _dbContext.SaveChangesAsync();
            }
            return orderHeader;
        }
    }
}
