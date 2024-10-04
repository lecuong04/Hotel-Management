namespace Hotel_Management.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } // Số phòng
        public string Status { get; set; }
        public int RoomType { get; set; }

        public Room() { }
    }
}
