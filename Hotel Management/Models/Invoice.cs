using System;

namespace Hotel_Management.Models
{
    [Table("HOADON", "MAHD")]
    public class Invoice
    {
        [Column("MAHD")]
        public int Id { get; set; }
        [Column("NGAYLAP")]
        public DateTime InvoiceDate { get; set; }
        [Column("TONGTIEN")]
        public int TotalPrice { get; set; }
        [Column("MANV")]
        public int Employee { get; set; }
        [Column("MAPHIEUDATPHONG")]
        public int BookingRoom { get; set; }

        public Invoice() { }
    }
}
