using Blazor.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blazor.Domain.Services.PhotoService
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetPhotos(int productSkuId);

        void Add(Photo photo);
    }
}
