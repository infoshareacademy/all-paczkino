using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace AllPaczkinoMVC.DTO
{
    public class ParcelCreationRequest
    {
        [Required]
        public string Name { get; set; }
		[Required]
		public int SenderLockerId { get; set; }
		[Required]
		public int ReceiverLockerId { get; set; }

		[Required]
		public string SenderName { get; set; }
		[Required]
		public string SenderSurname { get; set; }
		[Required]
		public string SenderEmail { get; set; }
		[Required]
		public string SenderPhoneNumber { get; set; }
		[Required]
		public string SenderStreetName { get; set; }
		[Required]
		public int SenderHouseNumber { get; set; }
		[Required]
		public string SenderCityName { get; set; }
		[Required]
		public string SenderPostalCode { get; set; }
		[Required]
		public string SenderCountry { get; set; }
		public int? SenderFlatNumber { get; set; }

		[Required]
		public string ReceiverName { get; set; }
		[Required]
		public string ReceiverSurname { get; set; }
		[Required]
		public string ReceiverEmail { get; set; }
		[Required]
		public string ReceiverPhoneNumber { get; set; }
		[Required]
		public string ReceiverStreetName { get; set; }
		[Required]
		public int ReceiverHouseNumber { get; set; }
		[Required]
		public string ReceiverCityName { get; set; }
		[Required]
		public string ReceiverPostalCode { get; set; }
		[Required]
		public string ReceiverCountry { get; set; }
		public int? ReceiverFlatNumber { get; set; }

		[Required]
		public string ParcelSize { get; set; }


		public SelectList Cities { get; set; }
		public SelectList SelectedSenderCity { get; set; }
		public SelectList SelectedReceiverCity { get; set; }
		public SelectList ParcelLockersInSelectedSenderCity { get; set; }
		public SelectList ParcelLockersInSelectedReceiverCity { get; set; }

	}

}
