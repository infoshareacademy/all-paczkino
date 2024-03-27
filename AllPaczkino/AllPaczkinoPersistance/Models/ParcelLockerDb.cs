
namespace AllPaczkino.Models
{
    public class ParcelLockerDb
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }

        public bool IsActive { get; set; }

    }
}
