﻿using Calendar.Models;

namespace Calendar.Services.RefreshTokenRepositories
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken> GetByToken(string token);
        Task Create(RefreshToken refreshToken);
        Task Delete(Guid id);
        Task DeleteAll(Guid userId);
    }
}
