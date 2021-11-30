using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Domain.Models.Products;
using Blazor.Domain.Services.PhotoService;
using Microsoft.EntityFrameworkCore;



namespace Blazor.Infrastructure.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly ApplicationDbContext context;
        public PhotoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Photo>> GetPhotos(int productSkuId)
        {
            return await context.Photos
              .Where(p => p.ProductSkuId == productSkuId)
              .ToListAsync();
        }

        public void Add(Photo photo)
        {
            context.Photos.Add(photo);

        }
    }
}