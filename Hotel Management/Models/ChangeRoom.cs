using System;

namespace Hotel_Management.Models
{
    public class ChangeRoom
    {
        public int Id { get; set; }
        public int BookingRoom { get; set; }
        public int OldRoom { get; set; }
        public int NewRoom { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Reason { get; set; }

        public ChangeRoom() { }
    }
}
