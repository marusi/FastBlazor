
using Blazor.Domain.Models;
using Blazor.Domain.Models.Products;
using Blazor.Domain.Models.Articles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Infrastructure.Models;
using System.Threading;

namespace Blazor.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        // converting classes to tables code first migration
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Product> Products {  get; set; }

        public DbSet<CompositeProduct> CompositeProducts { get; set; }

        public DbSet<Option> Options { get; set; }
        public DbSet<OptionValue> OptionValues { get; set; }
        public DbSet<SkuValue> SkuValues { get; set; }
        public DbSet<ProductSku> ProductSkus { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            //many to many relationship
            builder.Entity<CombinedProduct>().HasKey(ps =>
               new { ps.CompositeProductId, ps.ProductSkuId });

			var homePage = new ArticleDAO
			{
				Id = 1,
				Topic = "Home Page",
				Slug = "home-page",
				Content = "This is the default home page. Please change me!",
				Published = Instant.FromDateTimeUtc(new DateTime(2018, 6, 19, 14, 31, 2, 265, DateTimeKind.Utc)),
				AuthorId = Guid.Empty
			};

			var homePageHistory = ArticleHistoryDAO.FromArticle(homePage);
			homePageHistory.Id = 1;
			homePageHistory.Article = null;

			builder.Entity<ArticleDAO>(entity =>
			{
				entity.HasIndex(a => a.Slug).IsUnique();
				entity.HasData(homePage);
			});

			builder.Entity<ArticleHistoryDAO>(entity =>
			{
				entity.HasData(homePageHistory);
			});

			builder.Entity<SlugHistoryDAO>(entity =>
			{
				entity.HasIndex(a => new { a.OldSlug, a.AddedDateTime });
			});
		}

		public DbSet<ArticleDAO> Articles { get; set; }
		public DbSet<CommentDAO> Comments { get; set; }
		public DbSet<SlugHistoryDAO> SlugHistories { get; set; }

		public DbSet<ArticleHistoryDAO> ArticleHistories { get; set; }


		public override Task<int> SaveChangesAsync(
			CancellationToken cancellationToken = default(CancellationToken))
		{
			return base.SaveChangesAsync(cancellationToken);
		}


		public static void SeedData(ApplicationDbContext context)
		{

			context.Database.Migrate();

		}

	}
}
