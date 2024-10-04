using System;

namespace Hotel_Management.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; } // Ngày sinh
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string UniqueNumber { get; set; } // CCCD | Thị thực
        public string Country { get; set; }

        public Customer() { }
    }
}
