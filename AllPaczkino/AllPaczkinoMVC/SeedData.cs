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
            //change to synchro
            var userTask = _userManager.FindByEmailAsync("admin@example.com");
            var user2 = userTask.Result;
            // Seedowanie danych dla użytkowników
            if ((user2 is null))
            {
                var adminUser = new IdentityUser
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    EmailConfirmed = true
                };

                //change to synchro
                var createUserTask =  _userManager.CreateAsync(adminUser, "Pa$$w0rd");
                var createUserResultTask = createUserTask.Result;

                // Jeśli tworzenie użytkownika zakończyło się powodzeniem, nadaj mu rolę administratora
                if (createUserResultTask.Succeeded)
                {
                    //change to synchro
                    var addRoleTask = _userManager.AddToRoleAsync(adminUser, "ADMIN");
                    var addRoleTaskResult = addRoleTask.Result;
                }
                else
                {
                    // Obsłużanie ewentualnych błędów podczas tworzenia użytkownika
                    throw new Exception($"Nie można utworzyć użytkownika administratora. Błędy: {string.Join(", ", createUserResultTask.Errors)}");
                }
            }
            else
            {
                Console.WriteLine("dupa is null");
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
