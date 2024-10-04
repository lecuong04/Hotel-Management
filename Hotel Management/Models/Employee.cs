using System;

namespace Hotel_Management.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; } // Ngày sinh
        public string Phone { get; set; }
        public string UniqueNumber { get; set; } // CCCD
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; } // Chức vụ
        public DateTime DoW { get; set; } // Ngày vào làm
    }
}
