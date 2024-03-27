using AllPaczkino.Models;
using AllPaczkinoPersistance.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkinoPersistance.Repositories
{
	public interface IParcelsRepository
	{
		public List<ParcelDb> GetAll();

		public ParcelDb GetById(int id);

		Task Create(ParcelDb newParcel);

		public void Delete(int id);

		public void Update(int id, ParcelDb editedParcel);

		public ParcelDb GetByName(string name);

	}
}


