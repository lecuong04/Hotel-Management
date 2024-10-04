namespace Hotel_Management.Models
{
    public class BookingServiceDetail
    {
        public int BookingService { get; set; }
        public int Service { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public BookingServiceDetail() { }
    }
}
