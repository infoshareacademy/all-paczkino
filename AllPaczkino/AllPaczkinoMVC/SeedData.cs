using AllPaczkinoPersistance;
using Microsoft.AspNetCore.Identity;
using Microsoft.Graph.Models;

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
            // Seedowanie danych dla użytkowników
            if (await _userManager.FindByNameAsync("admin@example.com") == null)
            {
                var adminUser = new IdentityUser
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com"
                };

                // Tworzenie użytkownika
                var result = await _userManager.CreateAsync(adminUser, "Pa$$w0rd");

                // Jeśli tworzenie użytkownika zakończyło się powodzeniem, nadaj mu rolę administratora
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(adminUser, "Administrator");
                }
                else
                {
                    // Obsłużanie ewentualnych błędów podczas tworzenia użytkownika
                    throw new Exception($"Nie można utworzyć użytkownika administratora. Błędy: {string.Join(", ", result.Errors)}");
                }
            }

            // Sprawdź, czy baza danych jest pusta
            //if (!_context.Users.Any())
            //{
            //    // Dodaj przykładowych użytkowników
            //    var users = new List<User>
            //{
            //    new User {  Mail = "admin@admin.com",  },
            //    };
            //    //_context.Users.AddRange(users);
            //    _context.SaveChanges();
            //}

            // Dodaj więcej danych początkowych w podobny sposób
        }
    }

}
