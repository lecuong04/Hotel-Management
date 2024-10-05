using System;

namespace Hotel_Management.Models
{
    [Table("CHITIETPHIEUDAT")]
    public class BookingRoomDetail
    {
        [Column("MAPHIEUDATPHONG")]
        public int BookingRoom { get; set; }
        [Column("MAPHONG")]
        public int Room { get; set; }
        [Column("NGAYTRAPHONG")]
        public DateTime CheckoutDate { get; set; }

        public BookingRoomDetail() { }
    }
}
