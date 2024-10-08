﻿using System;

namespace Hotel_Management.Models
{
    [Table("PHIEUDICHVU")]
    public class BookingService
    {
        [Column("MAPHIEUDV", true, true)]
        public int Id { get; set; }
        [Column("NGAYLAP")]
        public DateTime BookingDate { get; set; }
        [Column("TONGTIEN")]
        public int TotalPrice { get; set; }
        [Column("MAPHIEUDATPHONG")]
        public int BookingRoom { get; set; }

        public BookingService() { }
    }
}
