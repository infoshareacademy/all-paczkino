using AllPaczkino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkinoPersistance.Repositories
{
    public class ParcelLockersEFRepository : IParcelLockersRepository
    {
        private readonly PaczkinoDbContext context;

        public ParcelLockersEFRepository(PaczkinoDbContext context)
        {
            this.context = context;
        }
        public List<ParcelLockerDb> GetAll()
        {
            return context.ParcelLockers.ToList();
            
        }
    }
}
