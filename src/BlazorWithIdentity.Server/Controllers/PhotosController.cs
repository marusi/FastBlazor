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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;



namespace BlazorWithIdentity.Server.Controllers
{
    [Route("/api/productskus/{productSkuId}/photos")]
  
    public class PhotosController : Controller
    {

       
        private readonly IHostingEnvironment host;
        private readonly IProductSkuRepository productSkuRepository;
        private readonly IPhotoRepository photoRepository;
        private readonly IMapper mapper;
      
        private readonly PhotoSettings photoSettings;
        private readonly IPhotoService photoService;
        public PhotosController(IHostingEnvironment host, IProductSkuRepository productSkuRepository, 
           IMapper mapper,  IPhotoService photoService, IOptionsSnapshot<PhotoSettings> options,
            IPhotoRepository photoRepository)
        {
            this.photoSettings = options.Value;
            this.host = host;
            this.productSkuRepository = productSkuRepository;
            this.photoRepository = photoRepository;
           
            this.photoService = photoService;
            this.mapper = mapper;
        }

   


        [HttpGet]
        public async Task<IEnumerable<PhotoDTO>> GetPhotos(int productSkuId)
        {
            var photos = await photoRepository.GetPhotos(productSkuId);

            return mapper.Map<IEnumerable<Photo>, IEnumerable<PhotoDTO>>(photos);
        }

        [HttpPost]
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
    }
}
