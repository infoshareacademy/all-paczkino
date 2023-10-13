using Parcels.Parcels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkino.Models
{
    public enum ParcelStatus
    {
        Registered,
        Sent,
        CollectedByCourier,
        InDelivery,
        ReadyToCollection,
        Received,
        Returned,
        Lost
    }
    public class Parcel
    {
        public ParcelStatus parcelStatus { get; set; }
        public ParcelSize parcelSize { get; set; }
        public decimal ParcelNumber { get; set; }
        public Parcel()
        {
            parcelStatus = ParcelStatus.Registered;
            ParcelNumber = (new Random()).Next(100000);

 
        }
    }
}
