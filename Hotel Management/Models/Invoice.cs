using System;

namespace Hotel_Management.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int TotalPrice { get; set; }
        public int Employee { get; set; }
        public int BookingRoom { get; set; }

        public Invoice() { }
    }
}
