using Hotel_Management.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hotel_Management.ViewModels
{
    public class ReservationViewModel
    {
        Reservation booking;
        ReservationDetail detail;
        Room room;
        Employee employee;
        Customer customer;

        public Reservation BookingRoom => booking;
        public ReservationDetail BookingRoomDetail => detail;
        public Room Room => room;
        public Employee Employee => employee;
        public Customer Customer => customer;

        public int Id { get; set; }
        public string BookingDate { get; set; }
        public string ArrivedDate { get; set; }
        public string ExpectedDate { get; set; }
        public string CheckoutDate { get; set; }
        public string EmployeeUnique { get; set; } // Tên nhân viên
        public string CustomerUnique { get; set; } // CCCD khách hàng
        public string RoomNumber { get; set; }

        public ReservationViewModel() { }

        public ReservationViewModel(Reservation booking, DbContext db, string dateFormat = "")
        {
            this.booking = booking;
            employee = db.GetTable<Employee>(x => x.Id == booking.Employee).First();
            customer = db.GetTable<Customer>(x => x.Id == booking.Customer).First();
            detail = db.GetTable<ReservationDetail>(x => x.Reservation == booking.Id).First();
            room = db.GetTable<Room>(x => x.Id == detail.Room).First();

            Id = booking.Id;
            BookingDate = booking.BookingDate.ToString(dateFormat);
            ArrivedDate = booking.ArrivedDate.ToString(dateFormat);
            if (booking.ExpectedDate.Year != 1)
                ExpectedDate = booking.ExpectedDate.ToString(dateFormat);
            EmployeeUnique = employee.UniqueNumber;
            CustomerUnique = customer.UniqueNumber;
            RoomNumber = room.Name;
            if (detail.CheckoutDate.Year != 1)
                CheckoutDate = detail.CheckoutDate.ToString(dateFormat);
        }

        public static IEnumerable<ReservationViewModel> GetBookingRooms(DbContext db, string dateFormat = "")
        {
            foreach (Reservation b in db.GetTable<Reservation>())
            {
                Employee employee = db.GetTable<Employee>(x => x.Id == b.Employee).First();
                Customer customer = db.GetTable<Customer>(x => x.Id == b.Customer).First();
                yield return new ReservationViewModel(b, db, dateFormat);
            }
        }
    }
}
