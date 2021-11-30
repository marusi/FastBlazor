using Blazor.Domain.Models.Products;
using Blazor.Domain.Services;
using Blazor.Domain.Services.PhotoService;
using Blazor.Infrastructure.Repositories;
using Domain.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace Blazor.Infrastructure.DI
{
    public class Loader
    {
        public static void Register(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration cfg)
        {
            var conn = cfg.GetConnectionString("Default");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(conn));
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOptionRepository, OptionRepository>();
            services.AddScoped<IOptionValueRepository, OptionValueRepository>();
            services.AddScoped<ISkuValueRepository, SkuValueRepository>();
            services.AddScoped<IProductSkuRepository, ProductSkuRepository>();
            services.AddScoped<ICompositeProductRepository, CompositeProductRepository>();
            
            

            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddTransient<IPhotoService, PhotoService>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddTransient<IPhotoStorage, FileSystemPhotoStorage>();


            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ISlugHistoryRepository, SlugHistoryRepository>();
           
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
        }
}
