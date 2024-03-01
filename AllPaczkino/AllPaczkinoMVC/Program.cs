using AllPaczkinoPersistance;
using AllPaczkinoPersistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AllPaczkinoMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<PaczkinoDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AllPaczkino")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()            
                .AddEntityFrameworkStores<PaczkinoDbContext>();

            builder.Services.AddTransient<IParcelLockersRepository, ParcelLockersEFRepository>();
            // Rejestracja usługi SeedData
            builder.Services.AddTransient<SeedData>();

            var app = builder.Build();

            // Seedowanie danych
            using (var scope = app.Services.CreateScope())
            {

                var services = scope.ServiceProvider;
                var seedData = services.GetRequiredService<SeedData>();
                seedData.Initialize();

            }

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
            app.UseAuthentication();
            app.UseAuthorization();

           
            //dodatkowe trasowanie zeby u�yc dodatkowego kontrolera dla logowania
            app.MapControllerRoute(
                name: "identity",
                pattern: "Identity/{action=Index}/{id?}",
                defaults: new { controller = "Identity" });
            //------------
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}