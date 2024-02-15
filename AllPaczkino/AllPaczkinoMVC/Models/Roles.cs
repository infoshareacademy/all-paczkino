using System.Runtime.Serialization;

namespace AllPaczkinoMVC.Models
{

    public enum Roles
    {
        [EnumMember(Value = "User")]
        Member = 0,

        [EnumMember(Value = "Admin")]
        Admin = 1,
    }

}
