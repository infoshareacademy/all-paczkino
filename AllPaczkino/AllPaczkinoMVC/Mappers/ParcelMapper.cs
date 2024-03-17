using AllPaczkino.Clients;
using AllPaczkino.Clients.ContactInfo;
using AllPaczkino.Models;
using AllPaczkinoLogic.Repositories;
using AllPaczkinoMVC.DTO;
using AllPaczkinoPersistance.Models;
using AllPaczkinoPersistance.Repositories;
using Microsoft.AspNetCore.Identity;
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
                0,
                request.Name,
                senderLocker,
                receiverLocker,
                DateTime.Now,
                sender,
                receiver,
                parcelSize
               );
        }

		public Parcel MapToParcel(ParcelDb request)
		{
			var senderLocker = ConvertToParcelLocker(request.SenderLocker);
			var receiverLocker = ConvertToParcelLocker(request.ReceiverLocker);

			var sender = new Sender
			{
				ContactData = new ContactData
				{
					Name = request.Sender.UserName,
					//Surname = request.Sender.
					Email = request.Sender.Email,
					PhoneNumber = request.Sender.PhoneNumber,
					//Adress = new Adress
					//{
					//	StreetName = request.SenderStreetName,
					//	HouseNumber = request.SenderHouseNumber,
					//	CityName = request.SenderCityName,
					//	PostalCode = request.SenderPostalCode,
					//	Country = request.SenderCountry,
					//	FlatNumber = request.SenderFlatNumber,
					//}
				}
			};
			var receiver = new Receiver
			{
				ContactData = new ContactData
				{
					Name = request.Receiver.UserName,
					//Surname = request.ReceiverSurname,
					Email = request.Receiver.Email,
					PhoneNumber = request.Receiver.PhoneNumber,
					//Adress = new Adress
					//{
					//	StreetName = request.ReceiverStreetName,
					//	HouseNumber = request.ReceiverHouseNumber,
					//	CityName = request.ReceiverCityName,
					//	PostalCode = request.ReceiverPostalCode,
					//	Country = request.ReceiverCountry,
					//	FlatNumber = request.ReceiverFlatNumber,
					//}
				}
			};
			var parcelSize = new ParcelSize { Name = request.ParcelSize.Name };


			return new Parcel(
				0,
				request.Name,
				senderLocker,
				receiverLocker,
				DateTime.Now,
				sender,
				receiver,
				parcelSize
			   );
		}

		public ParcelDb MapToParcelDb(Parcel request)
		{
			var senderLockerDb = _parcelLockersRepository.GetById(request.SenderLocker.id);
			var receiverLockerDb = _parcelLockersRepository.GetById(request.ReceiverLocker.id);

			var sender = new IdentityUser(request.Sender.ContactData.Email);
			var receiver = new IdentityUser(request.Receiver.ContactData.Email);

			var parcelSize = new ParcelSize { Name = request.ParcelSize.Name };


			return new ParcelDb(
				request.ID,
				request.Name,
				senderLockerDb,
				receiverLockerDb,
				DateTime.Now,
				sender,
				receiver,
				parcelSize
			   );
		}
	}


}