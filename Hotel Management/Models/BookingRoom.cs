using System;

namespace Hotel_Management.Models
{
    public class BookingRoom
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime ArrivedDate { get; set; }
        public DateTime ExpectedDate { get; set; }
        public int Employee { get; set; }
        public int Customer { get; set; }

        public BookingRoom() { }
    }
}
