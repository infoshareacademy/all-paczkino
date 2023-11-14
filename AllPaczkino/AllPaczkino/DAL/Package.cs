using AllPaczkino.Clients.ContactInfo;
using AllPaczkino.Models;

namespace AllPaczkino.DAL
{
    internal class Package
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Adress Address { get; set; }
        public ParcelLocker SenderLocker { get; set; }
        public ParcelLocker ReceiverLocker { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime ReceiveTime { get; set; }
        public ParcelStatus ParcelStatus { get; set; }
    }
}
