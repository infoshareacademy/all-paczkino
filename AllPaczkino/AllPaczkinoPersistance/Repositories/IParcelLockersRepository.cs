using AllPaczkino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkinoPersistance.Repositories
{
    public interface IParcelLockersRepository
    {
        List<ParcelLockerDb> GetAll();

        ParcelLockerDb GetById(int id);

        Task Create(ParcelLockerDb newParcelLocker);

        Task Delete(int id);

        Task Update(int id, ParcelLockerDb editedParcelLocker);
    }
}
