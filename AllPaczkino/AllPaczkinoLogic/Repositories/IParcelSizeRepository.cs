using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcels.Parcels;

namespace AllPaczkino.Repositories
{
    public interface IParcelSizeRepository
    {
        IEnumerable<ParcelSize> GetParcelSizeList();

    }
}
