using System;

namespace Hotel_Management.Models
{
    [Table("HOADON")]
    public class Invoice
    {
        [Column("MAHD", true, true)]
        public int Id { get; set; }
        [Column("NGAYLAP")]
        public DateTime InvoiceDate { get; set; }
        [Column("TONGTIEN")]
        public decimal TotalPrice { get; set; }
        [Column("MANV")]
        public int Employee { get; set; }
        [Column("MAPHIEUDATPHONG")]
        public int Reservation { get; set; }

        public Invoice() { }
    }
}
