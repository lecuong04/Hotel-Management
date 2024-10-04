using System;

namespace Hotel_Management.Models
{
    public class BookingService
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public int TotalPrice { get; set; }
        public int BookingRoom { get; set; }

        public BookingService() { }
    }
}
