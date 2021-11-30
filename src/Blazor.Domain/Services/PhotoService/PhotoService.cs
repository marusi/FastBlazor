using System;
using System.IO;
using System.Threading.Tasks;
using Blazor.Domain.Models.Products;
using Microsoft.AspNetCore.Http;


namespace Blazor.Domain.Services.PhotoService
{
    public class PhotoService : IPhotoService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IPhotoStorage photoStorage;
        public PhotoService(IUnitOfWork unitOfWork, IPhotoStorage photoStorage)
        {
            this.photoStorage = photoStorage;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Photo> UploadPhoto(ProductSku productSku, IFormFile file, string uploadsFolderPath)
        {
            var fileName = await photoStorage.StorePhoto(uploadsFolderPath, file);

            var photo = new Photo { PhotoFileName = fileName };
            productSku.Photos.Add(photo);
            await unitOfWork.CompleteAsync();

            return photo;
        }
    }
}