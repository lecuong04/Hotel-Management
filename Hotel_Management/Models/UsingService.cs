using System;

namespace Hotel_Management.Models
{
    [Table("PHIEUDICHVU")]
    public class UsingService
    {
        [Column("MAPHIEUDV", true, true)]
        public int Id { get; set; }
        [Column("NGAYLAP")]
        public DateTime BookingDate { get; set; }
        [Column("TONGTIEN")]
        public decimal TotalPrice { get; set; }
        [Column("MAPHIEUDATPHONG")]
        public int Reservation { get; set; }

        public UsingService() { }
    }
}
