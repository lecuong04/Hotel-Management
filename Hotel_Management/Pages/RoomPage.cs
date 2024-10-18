using Hotel_Management.ViewModels;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.ListView;

namespace Hotel_Management.Pages
{
    public partial class RoomPage : SfForm
    {
        DbContext db;

        public RoomPage(DbContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void RoomPage_Load(object sender, System.EventArgs e)
        {
            roomDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Number", HeaderText = "Số phòng" });
            roomDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Status", HeaderText = "Trạng thái" });
            roomDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Type", HeaderText = "Loại phòng" });
            roomDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Price", HeaderText = "Giá", Format = "C0" });
            roomDataGrid.Columns.Add(new GridTextColumn() { MappingName = "MaxPeople", HeaderText = "Tối đa" });
        }

        private void listPage_Enter(object sender, System.EventArgs e)
        {
            roomDataGrid.DataSource = RoomViewModel.GetRooms(db);
        }
    }
}
