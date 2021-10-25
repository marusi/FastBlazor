// using BlazorWithIdentity.Server.Data;
// using BlazorWithIdentity.Server.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
// using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Blazor.Infrastructure.DI;
using Blazor.Domain.Models;
using Blazor.Infrastructure;

namespace BlazorWithIdentity.Server
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            Loader.Register(services, Configuration);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ChamaSubAPI",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Edgar Wanjala Marakha",
                        Url = new Uri("https://www.github.com/marusi"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT UNlicense",
                        Url = new Uri("https://github.com/marusi/REPO/blob/master/LICENSE"),
                    }

                });
            });
            // services.AddDbContext<ApplicationDbContext>(options =>
            //   options.UseSqlite("Filename=data.db"));

              services.AddIdentity<AppUser, IdentityRole<Guid>>()
               .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
              {
                  // Password settings
                  options.Password.RequireDigit = true;
                  options.Password.RequiredLength = 6;
                  options.Password.RequireNonAlphanumeric = true;
                  options.Password.RequireUppercase = true;
                  options.Password.RequireLowercase = false;

                  // Lockout settings
                  options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                  options.Lockout.MaxFailedAccessAttempts = 10;
                  options.Lockout.AllowedForNewUsers = true;

                  // User settings
                  options.User.RequireUniqueEmail = false;

              }); 

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Events.OnRedirectToLogin = context =>
                {
                    context.Response.StatusCode = 401;
                    return Task.CompletedTask;
                };
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                //Note: Microsoft recommends to NOT migrate your database at Startup. 
                //You should consider your migration strategy according to the guidelines
             //   serviceScope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChamaSubAPI v1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
