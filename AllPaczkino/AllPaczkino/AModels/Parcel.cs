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
        public ParcelStatus parcelStatus  { get; set; }
    }
}
