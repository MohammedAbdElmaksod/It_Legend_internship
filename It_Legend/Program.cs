using Bl;
using Bl.Data;
using Domains;
using It_Legend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace It_Legend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IService<Jobs>, JobServices>();
            builder.Services.AddScoped<IService<Categories>, CategoryServices>();
            builder.Services.AddScoped<IService<Candidates>, Candidateservice>();
            builder.Services.AddScoped<IEployeeService, EmployeeService>();
            builder.Services.AddDbContext<ApplicationDbContext>
                (options => options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options=>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireUppercase= false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();
            //register autoMapper
            builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(MappingProfile)));
            Assembly[] oMapperProfile =
            {
                typeof(MappingProfile).Assembly
            };
            builder.Services.AddAutoMapper(oMapperProfile);
            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
            //end of register autoMapper
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}