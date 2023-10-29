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
        public ParcelStatus parcelStatus { get; set; }
        public ParcelSize parcelSize { get; set; }
        public decimal ParcelNumber { get; set; }
        public Parcel()
        {
            parcelStatus = ParcelStatus.Registered;
            ParcelNumber = (new Random()).Next(1000);

 
        }
    }
}
