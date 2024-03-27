using AllPaczkinoPersistance;
using Microsoft.AspNetCore.Identity;

namespace AllPaczkinoMVC
{
    public class SeedData
    {
        private readonly PaczkinoDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public SeedData(PaczkinoDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task Initialize()
        {
            if ((await _userManager.FindByEmailAsync("admin@allpaczkino.com") is null))
            {
                var adminUser = new IdentityUser
                {
                    UserName = "admin@allpaczkino.com",
                    Email = "admin@allpaczkino.com",
                    EmailConfirmed = true
                };

                var createUserResult = await _userManager.CreateAsync(adminUser, "A11P@czkin0");


                if (createUserResult.Succeeded)
                {
                    await _userManager.AddToRoleAsync(adminUser, "ADMIN");
                }
                else
                {
                    // Obsłużanie ewentualnych błędów podczas tworzenia użytkownika
                    throw new Exception($"Nie można utworzyć użytkownika administratora. Błędy: {string.Join(", ", createUserResult.Errors)}");
                }
            }
        }
    }

}
