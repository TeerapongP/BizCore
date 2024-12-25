using System.ComponentModel.DataAnnotations;

namespace BizCore.Entity;

public class BaseEntity
{
    public DateTime CreateDate { get; set; } = DateTime.UtcNow; // ตั้งค่าเริ่มต้นเป็นวันที่ปัจจุบัน
    public DateTime UpdateDate { get; set; } = DateTime.UtcNow;

    [StringLength(255)]  // จำกัดความยาวสูงสุด
    public string CreateBy { get; set; }

    [StringLength(255)]  // จำกัดความยาวสูงสุด
    public string UpdateBy { get; set; }
}