using firstMVC.Models;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace firstMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // NToastNotify
            builder.Services.AddRazorPages().AddNToastNotifyNoty(new NotyOptions
            {
                ProgressBar = true,
               
                Timeout = 5000 //5 seconds
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //Configure the Sql Server Database ConnectionStrings
            builder.Services.AddDbContext<EvryindiaContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("TEConnection")));
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