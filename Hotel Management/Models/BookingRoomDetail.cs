using System;

namespace Hotel_Management.Models
{
    public class BookingRoomDetail
    {
        public int BookingRoom { get; set; }
        public int Room { get; set; }
        public DateTime CheckoutDate { get; set; }

        public BookingRoomDetail() { }
    }
}
