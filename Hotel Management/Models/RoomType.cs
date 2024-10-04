namespace Hotel_Management.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int MaxPeople { get; set; }

        public RoomType() { }
    }
}
