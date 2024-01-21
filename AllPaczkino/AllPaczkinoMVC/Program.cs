using AllPaczkinoLogic.Models.DataContext;
using AllPaczkinoLogic.Repositories;

namespace AllPaczkinoMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AllPaczkinoDbContext>();


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AllPaczkinoDbContext>();

            var repository = new ParcelLockersRepository();

            var parcelLockers = repository.GetAll();

                foreach(var parcelLocker in parcelLockers)
            {
                parcelLocker.id = 0;
                dbContext.ParcelLockers.Add(parcelLocker);
            } 
            dbContext.SaveChanges();
            

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