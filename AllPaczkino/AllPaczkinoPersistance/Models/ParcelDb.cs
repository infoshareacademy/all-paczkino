using AllPaczkino.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AllPaczkino.Models;
using Microsoft.AspNetCore.Identity;
using Parcels.Parcels;

namespace AllPaczkinoPersistance.Models
{
	public class ParcelDb
	{
		public ParcelDb(int id, string name, ParcelLockerDb senderLockerDb, ParcelLockerDb receiverLockerDb, DateTime sendTime, IdentityUser sender, IdentityUser receiver, ParcelSize parcelSize)
		{
			ID = id;
			Name = name;
			SenderLocker = senderLockerDb;
			ReceiverLocker = receiverLockerDb;
			SendTime = sendTime;
			Sender = sender;
			Receiver = receiver;
			ParcelSize = parcelSize;
		}

		public ParcelDb() { }

		public string? ParcelNumber { get; set; }
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public ParcelLockerDb SenderLocker { get; set; }
		public ParcelLockerDb ReceiverLocker { get; set; }
		public DateTime SendTime { get; set; }
		public DateTime? ReceiveTime { get; set; }
		public ParcelStatus ParcelStatus { get; set; }
		public IdentityUser Sender { get; set; }
		public IdentityUser Receiver { get; set; }
		public ParcelSize ParcelSize { get; set; }
		
	}

	
};
