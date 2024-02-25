using AllPaczkinoPersistance;
using Microsoft.Graph.Models;

namespace AllPaczkinoMVC
{
    public class SeedData
    {
        private readonly PaczkinoDbContext _context;

        public SeedData(PaczkinoDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            // Sprawdź, czy baza danych jest pusta
            if (!_context.Users.Any())
            {
                // Dodaj przykładowych użytkowników
                var users = new List<User>
            {
                new User {  Mail = "admin@admin.com",  },
                };
                //_context.Users.AddRange(users);
                _context.SaveChanges();
            }

            // Dodaj więcej danych początkowych w podobny sposób
        }
    }

}
