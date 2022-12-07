using Calendar.Models;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Services.RefreshTokenRepositories
{
    public class DatabaseRefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly ApplicationDbContext _Context;
        public DatabaseRefreshTokenRepository(ApplicationDbContext context)
        {
            _Context = context;
        }
        public async Task Create(RefreshToken refreshToken)
        {
            _Context.refreshTokens.Add(refreshToken);
            await _Context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            RefreshToken refreshToken = await _Context.refreshTokens.FindAsync(id);
            if(refreshToken != null)
            {
                _Context.refreshTokens.Remove(refreshToken);
                await _Context.SaveChangesAsync();
            }
        }

        public async Task DeleteAll(Guid userId)
        {
            IEnumerable<RefreshToken> refreshTokens = await _Context.refreshTokens.Where(t => t.UserId == userId.ToString()).ToListAsync();
            _Context.refreshTokens.RemoveRange(refreshTokens);
            await _Context.SaveChangesAsync();
        }

        public async Task<RefreshToken> GetByToken(string token)
        {
            return await _Context.refreshTokens.FirstOrDefaultAsync(t => t.Token == token);
        }
    }
}
