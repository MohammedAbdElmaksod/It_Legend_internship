using Bl;
using Bl.Data;
using Castle.Core.Smtp;
using Domains;
using It_Legend.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
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
            builder.Services.AddScoped<IBlogService, BlogService>();
            builder.Services.AddScoped<ISuccessStoriesService,SuccessStoriesService>();
            builder.Services.AddScoped<IEmailSenderr,EmailSender>();
            builder.Services.AddScoped<IEmailTempalte,EmailTemplate>();
            builder.Services.AddDbContext<ApplicationDbContext>
                (options => options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));
            builder.Services.AddCloudscribePagination();
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options=>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireUppercase= false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Users/AccessDenied";
                options.LoginPath = "/Users/Login";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(200);
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.Cookie.Name = "Cookie";
                options.Cookie.HttpOnly = true;
                options.SlidingExpiration = true;
            });
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