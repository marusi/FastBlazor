using System.Threading.Tasks;
using Blazor.Domain.Models.Products;
using Microsoft.AspNetCore.Http;


namespace Blazor.Domain.Services.PhotoService
{
    public interface IPhotoService
    {
        Task<Photo> UploadPhoto(ProductSku productSku, IFormFile file, string uploadsFolderPath);
      
    }
}