using Finshark_api.Data;
using Finshark_api.Interfaces;
using Finshark_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Finshark_api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;
        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }
    }
}
