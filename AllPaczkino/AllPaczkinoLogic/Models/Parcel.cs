using AllPaczkino.Clients;
update columne using Parcels.Parcels;

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
        public DateTime ReceiveTime { get; set; }
        public ParcelStatus ParcelStatus { get; set; }
        public Sender Sender { get; set; }
        public Receiver Receiver { get; set; }
        public ParcelSize ParcelSize { get; set; }
        public Parcel()
        {
            ParcelStatus = ParcelStatus.Registered;
            ParcelNumber = (new Random()).Next(1000);
        }
    }
}
