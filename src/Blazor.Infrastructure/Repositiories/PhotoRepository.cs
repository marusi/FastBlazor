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

        public async Task<Photo> GetPhoto(int id, bool includeRelated = true)
        {
            if (!includeRelated)
                return await context.Photos.FindAsync(id);

            return await context.Photos
            .Include(p => p.ProductSkuId)

              .SingleOrDefaultAsync(p => p.Id == id);
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
        public void Remove(Photo photo)
        {
            context.Photos.Remove(photo);
        }
    }
}