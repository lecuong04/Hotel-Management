namespace Hotel_Management.Models
{
    [Table("CHITIETPHIEUDV")]
    public class BookingServiceDetail
    {
        [Column("MAPHIEUDV")]
        public int BookingService { get; set; }
        [Column("MADV")]
        public int Service { get; set; }
        [Column("DONGIA")]
        public int Price { get; set; }
        [Column("SOLUONG")]
        public int Quantity { get; set; }

        public BookingServiceDetail() { }
    }
}
