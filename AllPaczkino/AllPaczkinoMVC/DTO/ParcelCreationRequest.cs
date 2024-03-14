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
		public string ReceiverName { get; set; }
		[Required]
		public string ParcelSize { get; set; }

		public string SelectedSenderCity { get; set; }
		public string SelectedReceiverCity { get; set; }

		public SelectList Cities { get; set; }
		public SelectList ParcelLockersInSelectedSenderCity { get; set; }
		public SelectList ParcelLockersInSelectedReceiverCity { get; set; }

	}

}
