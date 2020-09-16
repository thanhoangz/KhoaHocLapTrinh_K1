using System.ComponentModel;

namespace Lesson8A.Enums
{
    public enum StatusEnum
    {
        [Description("Hoạt động")]
        Active,
        [Description("Dừng hoạt động")]
        Deactivated,
        [Description("Bảo lưu")]
        Reserve,
        [Description("Đình chỉ")]
        Suspended
    }
}
