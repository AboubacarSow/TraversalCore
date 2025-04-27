using Microsoft.AspNetCore.Http;
using Services.Contracts;
using FluentValidation;

namespace Services.Models
{
    public class FileManager : IFileService
    {
        public async Task<string> SaveImageAsync(IFormFile file)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (extension != ".jpg" && extension != ".png" && extension != ".jpeg")
                throw new ValidationException("Dosya Formatı Resim Olmalıdır");
            var imageName = String.Concat(Guid.NewGuid().ToString() + extension);

            var folder = Path.Combine(currentDirectory, "wwwroot/medias");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            var imagePath = Path.Combine(folder, imageName);
            using(var stream= new FileStream(imagePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return String.Concat("/medias/", imageName);
        }
    }
}