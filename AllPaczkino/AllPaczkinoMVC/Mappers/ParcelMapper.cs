using AllPaczkino.Clients;
using AllPaczkino.Clients.ContactInfo;
using AllPaczkino.Models;
using AllPaczkinoLogic.Repositories;
using AllPaczkinoMVC.DTO;
using Parcels.Parcels;

namespace AllPaczkinoMVC.Mappers
{
    public class ParcelMapper
    {
        private readonly ParcelLockersRepository parcelLockersRepository;

        public ParcelMapper(ParcelLockersRepository parcelLockersRepository)
        {
            this.parcelLockersRepository = parcelLockersRepository;
        }

        public Parcel MapToParcel(ParcelCreationRequest request)
        {
            var senderLocker = parcelLockersRepository.GetById(request.SenderLockerId);
            var receiverLocker = parcelLockersRepository.GetById(request.ReceiverLockerId);
            var sender = new Sender { ContactData = new ContactData { Name = request.SenderName } };
            var parcelSize = new ParcelSize { Name = request.ParcelSize };
            var receiver = new Receiver { ContactData = new ContactData { Name = request.ReceiverName } };

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