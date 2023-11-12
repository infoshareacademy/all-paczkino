using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using AllPaczkino.Clients.ContactInfo;
using AllPaczkino.Models;
using AllPaczkino.Tracking;

namespace AllPaczkino.DAL
{
    public class Package
    {
        private string sendTime;
        private string receiveTime;
        public string ID { get; set; }
        public decimal PackageNumber { get; set; }
        public string Name { get; set; }
        public Adress Address { get; set; }
        public ParcelLocker SenderLocker { get; set; }
        public ParcelLocker ReceiverLocker { get; set; }
        public string SendTime
        {
            get { return sendTime; }
            set { sendTime = value; }
        }
        public string ReceiveTime 
        {
            get { return receiveTime; }
            set { receiveTime = value; }
        }
        public ParcelStatus ParcelStatus { get; set; }

        public void GenerateSendTime()
        {
            sendTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
        }
        public void GenerateReceiveTime()
        {
            receiveTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
        }
    }
}
