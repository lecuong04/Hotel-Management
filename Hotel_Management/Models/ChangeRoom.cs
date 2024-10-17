﻿using System;

namespace Hotel_Management.Models
{
    [Table("DOITRAPHONG")]
    public class ChangeRoom
    {
        [Column("MADOITRA", true, true)]
        public int Id { get; set; }
        [Column("MAPHIEUDATPHONG")]
        public int Reservation { get; set; }
        [Column("PHONGCU")]
        public int OldRoom { get; set; }
        [Column("PHONGMOI")]
        public int NewRoom { get; set; }
        [Column("NGAYDOI")]
        public DateTime ChangeDate { get; set; }
        [Column("LYDO")]
        public string Reason { get; set; }

        public ChangeRoom() { }
    }
}
