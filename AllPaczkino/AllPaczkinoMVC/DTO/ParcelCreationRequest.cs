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
    }
}
