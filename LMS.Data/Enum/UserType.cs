using System.ComponentModel;

namespace LMS.Data
{
    public enum UserType
    {
        [Description("Admin")]
        Admin,

        [Description("SubAdmin")]
        SubAdmin,

        [Description("SalesPerson")]
        SalesPerson
    }
}