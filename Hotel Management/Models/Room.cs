namespace Hotel_Management.Models
{
    [Table("PHONG", "MAPHONG")]
    public class Room
    {
        [Column("MAPHONG")]
        public int Id { get; set; }
        [Column("SOPHONG")]
        public string Name { get; set; } // Số phòng
        [Column("TINHTRANG")]
        public string Status { get; set; }
        [Column("MALOAIPHONG")]
        public int RoomType { get; set; }

        public Room() { }
    }
}
