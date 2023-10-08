using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaczkino.Models
{
    public class ParcelLocker
    {
        public int id { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string address { get; set; }
    }

    public class ParcelLockerList
    {
        public List<ParcelLocker> parcel_lockers { get; set; }
    }
}
