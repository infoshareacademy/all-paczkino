using AllPaczkino.Models;
using AllPaczkinoPersistance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkinoPersistance.Repositories
{
	public class ParcelsEFRepository : IParcelsRepository
	{
		private PaczkinoDbContext context;
		public ParcelsEFRepository(PaczkinoDbContext context)
		{
			this.context = context;
		}
		public async Task Create(ParcelDb newParcel)
		{
			context.Parcels.Add(newParcel);
			await context.SaveChangesAsync();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<ParcelDb> GetAll()
		{
			return context.Parcels
				.Include(p => p.ReceiverLocker)
				.Include(p => p.SenderLocker)
				.Include(p => p.Sender)
				.Include(p => p.Receiver)
				.ToList();
		}

		public ParcelDb GetById(int id)
		{
			throw new NotImplementedException();
		}

		public ParcelDb GetByName(string name)
		{
			throw new NotImplementedException();
		}

		public void Update(int id, ParcelDb editedParcel)
		{
			throw new NotImplementedException();
		}
	}
}
