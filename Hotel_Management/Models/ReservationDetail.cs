using System;

namespace Hotel_Management.Models
{
    [Table("CHITIETPHIEUDAT")]
    public class ReservationDetail
    {
        [Column("MAPHIEUDATPHONG", true)]
        public int Reservation { get; set; }
        [Column("MAPHONG", true)]
        public int Room { get; set; }
        [Column("NGAYTRAPHONG")]
        public DateTime CheckoutDate { get; set; }

        public ReservationDetail() { }
    }
}
