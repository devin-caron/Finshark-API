﻿using Finshark_api.Models;

namespace Finshark_api.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment> UpdateAsync(int id, Comment comment);
        Task<Comment> DeleteAsync(int id);
    }
}
