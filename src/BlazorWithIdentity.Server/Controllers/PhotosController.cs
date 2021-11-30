using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blazor.Domain.Models.Products;
using Blazor.Domain.Services;
using Blazor.Domain.Services.PhotoService;
using BlazorWithIdentity.Shared.DTO.Photo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;



namespace BlazorWithIdentity.Server.Controllers
{
    [Route("/api/productskus/")]
  
    public class PhotosController : Controller
    {

       
        private readonly IHostingEnvironment host;
        private readonly IProductSkuRepository productSkuRepository;
        private readonly IPhotoRepository photoRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly PhotoSettings photoSettings;
        private readonly IPhotoService photoService;
        public PhotosController(IHostingEnvironment host, IProductSkuRepository productSkuRepository, 
           IMapper mapper,  IPhotoService photoService, IOptionsSnapshot<PhotoSettings> options,
            IPhotoRepository photoRepository, IUnitOfWork unitOfWork)
        {
            this.photoSettings = options.Value;
            this.host = host;
            this.productSkuRepository = productSkuRepository;
            this.photoRepository = photoRepository;
            this.unitOfWork = unitOfWork;
            this.photoService = photoService;
            this.mapper = mapper;
        }

   


        [HttpGet("{productSkuId}/photos")]
        public async Task<IEnumerable<PhotoDTO>> GetPhotos(int productSkuId)
        {
            var photos = await photoRepository.GetPhotos(productSkuId);

            return mapper.Map<IEnumerable<Photo>, IEnumerable<PhotoDTO>>(photos);
        }

        [HttpPost("{productSkuId}/photos")]
        public async Task<IActionResult> Upload(int productSkuId, IFormFile file)
        {
            var productSku = await productSkuRepository.GetProductSku(productSkuId, includeRelated: false);

            if (productSku == null)
                return NotFound();


            if (file == null) return BadRequest("Null Photo File");
            if (file.Length == 0) return BadRequest("Empty Photo File");
            if (file.Length > photoSettings.MaxBytes) return BadRequest("Maximum file size exceeded");
            if (!photoSettings.IsSupported(file.FileName)) return BadRequest("File type is invalid");

            var uploadsFolderPath = Path.Combine(host.WebRootPath, "photoUploads");

            var photo = await photoService.UploadPhoto(productSku, file, uploadsFolderPath);

            return Ok(mapper.Map<Photo, PhotoDTO>(photo));

        }
        

        [HttpDelete("{id}/photo")]
        [Authorize]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var photo = await photoRepository.GetPhoto(id, includeRelated: false);

            if (photo == null)
                return NotFound();

            photoRepository.Remove(photo);
            var imagePath = Path.Combine(host.WebRootPath, "photoUploads", photo.PhotoFileName);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            await unitOfWork.CompleteAsync();

            return Ok(id);
        }

    }
}
