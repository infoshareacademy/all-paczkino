using System.Runtime.Serialization;

namespace AllPaczkinoMVC.Models
{

    public enum Roles
    {
        [EnumMember(Value = "Member")]
        Member = 0,

        [EnumMember(Value = "Admin")]
        Admin = 1,
    }

}
