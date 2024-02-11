using AllPaczkino.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace AllPaczkinoPersistance.Repositories
{
    public class ParcelLockersEFRepository : IParcelLockersRepository
    {
        private PaczkinoDbContext context;

        public ParcelLockersEFRepository(PaczkinoDbContext context)
        {
            this.context = context;
        }
        public List<ParcelLockerDb> GetAll()
        {
            return context.ParcelLockers.ToList();

        }
        public ParcelLockerDb GetById(int id)
        {
            List<ParcelLockerDb> items = GetAll();
            return items.FirstOrDefault(x => x.Id == id);
        }
        public async Task Create(ParcelLockerDb newParcelLocker)
        {
            context.ParcelLockers.Add(newParcelLocker);
            await context.SaveChangesAsync();

        }
        public async Task Delete(int id)
        {

            var parcelLockerToRemove = await context.ParcelLockers.FirstOrDefaultAsync(x => x.Id == id);

            context.ParcelLockers.Remove(parcelLockerToRemove);
            await context.SaveChangesAsync();
        }
        public async Task Update(int id, ParcelLockerDb editedParcelLocker)
        {
            var parcelLockertoUpdate = await context.ParcelLockers.FirstOrDefaultAsync(x => x.Id == id);
            if (parcelLockertoUpdate != null)
            {
                parcelLockertoUpdate.City = editedParcelLocker.City;
                parcelLockertoUpdate.Address = editedParcelLocker.Address;
                parcelLockertoUpdate.PostalCode = editedParcelLocker.PostalCode;
                parcelLockertoUpdate.IsActive  = editedParcelLocker.IsActive;
                await context.SaveChangesAsync();
            }
        }

    }
}
