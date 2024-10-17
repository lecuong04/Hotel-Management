using Hotel_Management.ViewModels;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;

namespace Hotel_Management.Pages
{
    public partial class ReservationPage : SfForm
    {
        DbContext db;

        public ReservationPage(DbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void ReservationPage_Load(object sender, EventArgs e)
        {
            reservationDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Id", HeaderText = "Mã đặt phòng" });
            reservationDataGrid.Columns.Add(new GridTextColumn() { MappingName = "RoomNumber", HeaderText = "Phòng" });
            reservationDataGrid.Columns.Add(new GridTextColumn() { MappingName = "BookingDate", HeaderText = "Ngày đặt" });
            reservationDataGrid.Columns.Add(new GridTextColumn() { MappingName = "ArrivedDate", HeaderText = "Ngày đến" });
            reservationDataGrid.Columns.Add(new GridTextColumn() { MappingName = "ExpectedDate", HeaderText = "Ngày rời dự kiến" });
            reservationDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CheckoutDate", HeaderText = "Ngày rời thực tế" });
            reservationDataGrid.Columns.Add(new GridTextColumn() { MappingName = "EmployeeUnique", HeaderText = "Nhân viên" });
            reservationDataGrid.Columns.Add(new GridTextColumn() { MappingName = "CustomerUnique", HeaderText = "Khách hàng" });
        }

        private void listPage_Enter(object sender, EventArgs e)
        {
            reservationDataGrid.DataSource = ReservationViewModel.GetBookingRooms(db, "dd-MM-yyyy | HH:mm");
        }
    }
}
