using Microsoft.AspNetCore.Http;

namespace Services.Contracts
{
    public interface IFileService
    {
        Task<String> SaveImageAsync(IFormFile file);
    }
}