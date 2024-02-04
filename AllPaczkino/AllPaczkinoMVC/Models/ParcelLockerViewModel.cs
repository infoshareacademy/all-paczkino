using Microsoft.AspNetCore.Mvc.Rendering;

namespace AllPaczkinoMVC.Models
{
    public class ParcelLockerViewModel
    {
        public string SelectedCity { get; set; }
        public string SelectedParcelLocker { get; set; }
        public SelectList Cities { get; set; }
        public SelectList ParcelLockersInSelectedCity { get; set; }
    }
}
