using Hotel_Management.Models;
using Hotel_Management.ViewModels;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;

namespace Hotel_Management.Pages
{
    public partial class RoomPage : SfForm
    {
        bool updateSplit = true;

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

            roomTypeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Name", HeaderText = "Loại phòng" });
            roomTypeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Price", HeaderText = "Giá tiền", Format = "C0" });
            roomTypeDataGrid.Columns.Add(new GridTextColumn() { MappingName = "MaxPeople", HeaderText = "Số người tối đa" });
        }

        private void listPage_Enter(object sender, System.EventArgs e)
        {
            roomDataGrid.DataSource = RoomViewModel.GetRooms(db);
            roomTypeDataGrid.DataSource = db.GetTable<RoomType>();
        }

        private void splitContainer_MouseDown(object sender, MouseEventArgs e)
        {
            if (!updateSplit)
                return;
            SplitContainer c = sender as SplitContainer;
            c.IsSplitterFixed = true;
        }

        private void splitContainer_MouseUp(object sender, MouseEventArgs e)
        {
            if (!updateSplit)
                return;
            SplitContainer c = sender as SplitContainer;
            c.IsSplitterFixed = false;
        }

        private void splitContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (!updateSplit)
                return;
            SplitContainer c = sender as SplitContainer;
            if (c.IsSplitterFixed)
            {
                if (e.Button.Equals(MouseButtons.Left))
                {
                    if (c.Orientation.Equals(Orientation.Vertical))
                    {
                        if (e.X > 0 && e.X < c.Width)
                        {
                            c.SplitterDistance = e.X;
                            c.Refresh();
                        }
                    }
                    else
                    {
                        if (e.Y > 0 && e.Y < c.Height)
                        {
                            c.SplitterDistance = e.Y;
                            c.Refresh();
                        }
                    }
                }
                else
                {
                    c.IsSplitterFixed = false;
                }
            }
        }
    }
}
