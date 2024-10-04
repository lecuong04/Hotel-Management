using System;

namespace Hotel_Management.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int Invoice { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public DateTime PaymentTerm { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment() { }
    }
}
