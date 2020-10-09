using System.ComponentModel;

namespace QuanLyLinhKienPC.Services.Enums
{
    public enum LinhKienStatusEnum
    {
        [Description("Trạng thái còn hàng")]
        Active,
        [Description("Trạng thái hết hàng")]
        InActive
    }
}
