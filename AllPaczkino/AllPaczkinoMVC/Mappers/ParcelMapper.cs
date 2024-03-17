using AllPaczkino.Clients;
using AllPaczkino.Clients.ContactInfo;
using AllPaczkino.Models;
using AllPaczkinoLogic.Repositories;
using AllPaczkinoMVC.DTO;
using AllPaczkinoPersistance.Repositories;
using Parcels.Parcels;

namespace AllPaczkinoMVC.Mappers
{
    public class ParcelMapper
    {
		private IParcelLockersRepository _parcelLockersRepository;
		
        public ParcelMapper(IParcelLockersRepository parcelLockersRepository)
        {
			_parcelLockersRepository = parcelLockersRepository;
		}

		private ParcelLocker ConvertToParcelLocker(ParcelLockerDb parcelLockerDb)
		{
			return new ParcelLocker
			{
				id = parcelLockerDb.Id,
				address = parcelLockerDb.Address,
				postal_code = parcelLockerDb.PostalCode,
				city = parcelLockerDb.City
			};
		}

		public Parcel MapToParcel(ParcelCreationRequest request)
        {
			var senderLockerDb = _parcelLockersRepository.GetById(request.SenderLockerId);
			var receiverLockerDb = _parcelLockersRepository.GetById(request.ReceiverLockerId);

			var senderLocker = ConvertToParcelLocker(senderLockerDb);
			var receiverLocker = ConvertToParcelLocker(receiverLockerDb);

			var sender = new Sender
            {
                ContactData = new ContactData
                {
                    Name = request.SenderName,
                    Surname = request.SenderSurname,
                    Email = request.SenderEmail,
                    PhoneNumber = request.SenderPhoneNumber,
                    Adress = new Adress
                    {
                        StreetName = request.SenderStreetName,
                        HouseNumber = request.SenderHouseNumber,
                        CityName = request.SenderCityName,
                        PostalCode = request.SenderPostalCode,
                        Country = request.SenderCountry,
                        FlatNumber = request.SenderFlatNumber,
                    }
                }
            };
			var receiver = new Receiver
			{
				ContactData = new ContactData
				{
					Name = request.ReceiverName,
					Surname = request.ReceiverSurname,
					Email = request.ReceiverEmail,
					PhoneNumber = request.ReceiverPhoneNumber,
					Adress = new Adress
					{
						StreetName = request.ReceiverStreetName,
						HouseNumber = request.ReceiverHouseNumber,
						CityName = request.ReceiverCityName,
						PostalCode = request.ReceiverPostalCode,
						Country = request.ReceiverCountry,
						FlatNumber = request.ReceiverFlatNumber,
					}
				}
			};
			var parcelSize = new ParcelSize { Name = request.ParcelSize };
            

            return new Parcel(
                new Random().Next(1000),
                request.Name,
                senderLocker,
                receiverLocker,
                DateTime.Now,
                sender,
                receiver,
                parcelSize
               );
        }
    }
}