namespace Hotel_Management.Models
{
    [Table("CHITIETPHIEUDV")]
    public class UsingServiceDetail
    {
        [Column("MAPHIEUDV", true)]
        public int UsingService { get; set; }
        [Column("MADV", true)]
        public int Service { get; set; }
        [Column("DONGIA")]
        public decimal Price { get; set; }
        [Column("SOLUONG")]
        public int Quantity { get; set; }

        public UsingServiceDetail() { }
    }
}
