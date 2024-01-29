using AllPaczkino.Clients;
using Parcels.Parcels;

namespace AllPaczkino.Models
{
    public enum ParcelStatus
    {
        Registered,
        Sent,
        CollectedByCourier,
        InDelivery,
        ReadyToCollect,
        Received,
        Returned
    }
    public class Parcel
    {
        public decimal ParcelNumber { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public ParcelLocker SenderLocker { get; set; }
        public ParcelLocker ReceiverLocker { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public ParcelStatus ParcelStatus { get; set; }
        public Sender Sender { get; set; }
        public Receiver Receiver { get; set; }
        public ParcelSize ParcelSize { get; set; }

        public Parcel(int id, string name, ParcelLocker senderLocker, 
            ParcelLocker receiverLocker, DateTime sendTime, Sender sender, Receiver receiver, ParcelSize parcelSize)
        {
            ParcelNumber = (new Random()).Next(1000);
            ID = id;
            Name = name;
            SenderLocker = senderLocker;
            ReceiverLocker = receiverLocker;
            SendTime = sendTime;
            ReceiveTime = null;
            ParcelStatus = ParcelStatus.Registered;
            Sender = sender;
            Receiver = receiver;
            ParcelSize = parcelSize;
        }

        public Parcel()
        {
               
        }
    }

  
    
}
