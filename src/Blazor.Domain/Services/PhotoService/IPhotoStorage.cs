using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace Blazor.Domain.Services.PhotoService
{
    public interface IPhotoStorage
    {
         Task<string> StorePhoto(string uploadsFolderPath, IFormFile file);
         
    }
}