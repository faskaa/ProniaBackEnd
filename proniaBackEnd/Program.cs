using Microsoft.EntityFrameworkCore;
using proniaBackEnd.DAL;
using proniaBackEnd.Services;

namespace proniaBackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ProniaDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddScoped<LayoutService>();
            var app = builder.Build();

                
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });

            app.UseStaticFiles();
            app.Run();
        }
    }
}