using Finshark_api.Data;
using Finshark_api.Interfaces;
using Finshark_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Finshark_api.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext _context;

        public StockRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<List<Stock>> GetAllAsync()
        {
            return _context.Stocks.ToListAsync();
        }
    }
}
