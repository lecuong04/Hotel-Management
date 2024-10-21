using Hotel_Management.Models;
using Hotel_Management.Models.Extensions;
using System.Collections.Generic;

namespace Hotel_Management.ViewModels
{
    public class RoomViewModel
    {
        Room room;
        RoomType type;

        public Room Room => room;
        public RoomType RoomType => type;

        public int Id { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int MaxPeople { get; set; }

        public RoomViewModel() { }

        public RoomViewModel(Room r, DbContext db)
        {
            room = r;
            type = r.GetRoomType(db);

            Id = r.Id;
            Number = r.Name;
            Status = r.Status;
            Type = type.Name;
            Price = type.Price;
            MaxPeople = type.MaxPeople;
        }

        public static IEnumerable<RoomViewModel> GetRooms(DbContext db)
        {
            foreach (Room room in db.GetTable<Room>())
            {
                yield return new RoomViewModel(room, db);
            }
        }
    }
}
