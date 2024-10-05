namespace Hotel_Management.Models
{
    [Table("DICHVU")]
    public class Service
    {
        [Column("MADV")]
        public int Id { get; set; }
        [Column("TENDV")]
        public string Name { get; set; }
        [Column("DONGIA")]
        public int Price { get; set; }

        public Service() { }
    }
}
