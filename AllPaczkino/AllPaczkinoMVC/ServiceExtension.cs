using AllPaczkinoMVC.Models;
using AllPaczkinoPersistance;
using Microsoft.AspNetCore.Identity;

namespace AllPaczkinoMVC
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<PaczkinoDbContext>();

            services.ConfigureApplicationCookie(option => {
                option.LoginPath = "/Identity/Signin";
                option.AccessDeniedPath = "/Identity/AccessDenied";
                option.ExpireTimeSpan = TimeSpan.FromHours(10);
            });
            services.AddAuthorization(option => {

                option.AddPolicy("Member", p => {

                    p.RequireRole(Roles.Member.ToString());
                });

                option.AddPolicy("Admin", p => {

                    p.RequireRole(Roles.Admin.ToString());
                });
            });

            services.AddControllersWithViews();

            return services;
        }
    }
}
