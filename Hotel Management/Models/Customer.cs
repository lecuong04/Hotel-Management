using System;

namespace Hotel_Management.Models
{
    [Table("KHACHHANG", "MAKH")]
    public class Customer
    {
        [Column("MAKH")]
        public int Id { get; set; }
        [Column("TENKH")]
        public string Name { get; set; }
        [Column("NGSINH")]
        public DateTime DoB { get; set; } // Ngày sinh
        [Column("GIOITINH")]
        public string Gender { get; set; }
        [Column("SDT")]
        public string Phone { get; set; }
        [Column("MADD")]
        public string UniqueNumber { get; set; } // CCCD | Thị thực
        [Column("QUOCTICH")]
        public string Country { get; set; }

        public Customer() { }
    }
}
