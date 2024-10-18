namespace Hotel_Management.Pages
{
    partial class RoomPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roomTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.listPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.roomDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.addPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtType = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.numMax = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.btnTypeAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.numPrice = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel13 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel14 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtRoom = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cboType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnRoomAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel15 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cboStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomTabControl)).BeginInit();
            this.roomTabControl.SuspendLayout();
            this.listPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGrid)).BeginInit();
            this.addPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // roomTabControl
            // 
            this.roomTabControl.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.roomTabControl.BeforeTouchSize = new System.Drawing.Size(798, 448);
            this.roomTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomTabControl.BorderVisible = true;
            this.roomTabControl.Controls.Add(this.listPage);
            this.roomTabControl.Controls.Add(this.addPage);
            this.roomTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTabControl.Location = new System.Drawing.Point(2, 2);
            this.roomTabControl.Name = "roomTabControl";
            this.roomTabControl.RotateTextWhenVertical = true;
            this.roomTabControl.Size = new System.Drawing.Size(798, 448);
            this.roomTabControl.TabIndex = 0;
            this.roomTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            this.roomTabControl.ThemeName = "TabRendererOffice2016White";
            this.roomTabControl.ThemesEnabled = true;
            // 
            // listPage
            // 
            this.listPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPage.Controls.Add(this.roomDataGrid);
            this.listPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listPage.Image = null;
            this.listPage.ImageSize = new System.Drawing.Size(16, 16);
            this.listPage.Location = new System.Drawing.Point(2, 26);
            this.listPage.Name = "listPage";
            this.listPage.ShowCloseButton = true;
            this.listPage.Size = new System.Drawing.Size(794, 420);
            this.listPage.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPage.TabIndex = 1;
            this.listPage.Text = "Danh sách";
            this.listPage.ThemesEnabled = false;
            this.listPage.Enter += new System.EventHandler(this.listPage_Enter);
            // 
            // roomDataGrid
            // 
            this.roomDataGrid.AccessibleName = "Table";
            this.roomDataGrid.AllowEditing = false;
            this.roomDataGrid.AllowFiltering = true;
            this.roomDataGrid.AllowResizingColumns = true;
            this.roomDataGrid.AutoGenerateColumns = false;
            this.roomDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.roomDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomDataGrid.Location = new System.Drawing.Point(0, 0);
            this.roomDataGrid.Name = "roomDataGrid";
            this.roomDataGrid.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.roomDataGrid.Size = new System.Drawing.Size(794, 420);
            this.roomDataGrid.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomDataGrid.Style.CellStyle.Font.Size = 10F;
            this.roomDataGrid.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.roomDataGrid.Style.HeaderStyle.Font.Size = 10F;
            this.roomDataGrid.TabIndex = 0;
            this.roomDataGrid.Text = "sfDataGrid1";
            this.roomDataGrid.ThemeName = "Office2016Colorful";
            // 
            // addPage
            // 
            this.addPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addPage.Controls.Add(this.tableLayoutPanel1);
            this.addPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.addPage.Image = null;
            this.addPage.ImageSize = new System.Drawing.Size(16, 16);
            this.addPage.Location = new System.Drawing.Point(2, 26);
            this.addPage.Name = "addPage";
            this.addPage.ShowCloseButton = true;
            this.addPage.Size = new System.Drawing.Size(794, 420);
            this.addPage.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPage.TabIndex = 2;
            this.addPage.Text = "Thêm";
            this.addPage.ThemesEnabled = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 420);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại phòng";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.autoLabel10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.autoLabel11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.autoLabel12, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtType, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.numMax, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnTypeAdd, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.numPrice, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(782, 169);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // autoLabel10
            // 
            this.autoLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel10.Location = new System.Drawing.Point(3, 10);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(114, 20);
            this.autoLabel10.TabIndex = 0;
            this.autoLabel10.Text = "Tên loại";
            this.autoLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel10.ThemeName = "Office2016Colorful";
            // 
            // autoLabel11
            // 
            this.autoLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel11.Location = new System.Drawing.Point(3, 50);
            this.autoLabel11.Name = "autoLabel11";
            this.autoLabel11.Size = new System.Drawing.Size(114, 20);
            this.autoLabel11.TabIndex = 1;
            this.autoLabel11.Text = "Giá phòng";
            this.autoLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel11.ThemeName = "Office2016Colorful";
            // 
            // autoLabel12
            // 
            this.autoLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel12.Location = new System.Drawing.Point(404, 10);
            this.autoLabel12.Name = "autoLabel12";
            this.autoLabel12.Size = new System.Drawing.Size(114, 20);
            this.autoLabel12.TabIndex = 2;
            this.autoLabel12.Text = "Tối đa";
            this.autoLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel12.ThemeName = "Office2016Colorful";
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtType.BeforeTouchSize = new System.Drawing.Size(255, 26);
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtType.Location = new System.Drawing.Point(123, 7);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(255, 26);
            this.txtType.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtType.TabIndex = 3;
            this.txtType.ThemeName = "Office2016Colorful";
            // 
            // numMax
            // 
            this.numMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numMax.BackColor = System.Drawing.Color.White;
            this.numMax.BeforeTouchSize = new System.Drawing.Size(255, 26);
            this.numMax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numMax.Location = new System.Drawing.Point(524, 7);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(255, 26);
            this.numMax.TabIndex = 5;
            this.numMax.ThemeName = "Office2016Colorful";
            this.numMax.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTypeAdd.AutoSize = true;
            this.btnTypeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTypeAdd.Location = new System.Drawing.Point(524, 44);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnTypeAdd.Size = new System.Drawing.Size(255, 31);
            this.btnTypeAdd.TabIndex = 6;
            this.btnTypeAdd.Text = "Thêm";
            this.btnTypeAdd.ThemeName = "Office2016Colorful";
            // 
            // numPrice
            // 
            this.numPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numPrice.BackColor = System.Drawing.Color.White;
            this.numPrice.BeforeTouchSize = new System.Drawing.Size(255, 26);
            this.numPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.numPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numPrice.Location = new System.Drawing.Point(123, 47);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(255, 26);
            this.numPrice.TabIndex = 4;
            this.numPrice.ThemeName = "Office2016Colorful";
            this.numPrice.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.autoLabel13, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.autoLabel14, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtRoom, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cboType, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnRoomAdd, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.autoLabel15, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.cboStatus, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(782, 169);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // autoLabel13
            // 
            this.autoLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel13.Location = new System.Drawing.Point(3, 10);
            this.autoLabel13.Name = "autoLabel13";
            this.autoLabel13.Size = new System.Drawing.Size(114, 20);
            this.autoLabel13.TabIndex = 0;
            this.autoLabel13.Text = "Số phòng";
            this.autoLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel13.ThemeName = "Office2016Colorful";
            // 
            // autoLabel14
            // 
            this.autoLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel14.Location = new System.Drawing.Point(404, 10);
            this.autoLabel14.Name = "autoLabel14";
            this.autoLabel14.Size = new System.Drawing.Size(114, 20);
            this.autoLabel14.TabIndex = 1;
            this.autoLabel14.Text = "Loại phòng";
            this.autoLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel14.ThemeName = "Office2016Colorful";
            // 
            // txtRoom
            // 
            this.txtRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtRoom.BeforeTouchSize = new System.Drawing.Size(255, 26);
            this.txtRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtRoom.Location = new System.Drawing.Point(123, 7);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(255, 26);
            this.txtRoom.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtRoom.TabIndex = 2;
            this.txtRoom.ThemeName = "Office2016Colorful";
            // 
            // cboType
            // 
            this.cboType.AllowDropDownResize = false;
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.BackColor = System.Drawing.Color.White;
            this.cboType.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cboType.Location = new System.Drawing.Point(524, 7);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(255, 26);
            this.cboType.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cboType.Style.EditorStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cboType.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.cboType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboType.TabIndex = 3;
            this.cboType.TabStop = false;
            this.cboType.ThemeName = "Office2016Colorful";
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoomAdd.AutoSize = true;
            this.btnRoomAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRoomAdd.Location = new System.Drawing.Point(524, 44);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnRoomAdd.Size = new System.Drawing.Size(255, 31);
            this.btnRoomAdd.TabIndex = 5;
            this.btnRoomAdd.Text = "Thêm";
            this.btnRoomAdd.ThemeName = "Office2016Colorful";
            // 
            // autoLabel15
            // 
            this.autoLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel15.Location = new System.Drawing.Point(3, 50);
            this.autoLabel15.Name = "autoLabel15";
            this.autoLabel15.Size = new System.Drawing.Size(114, 20);
            this.autoLabel15.TabIndex = 5;
            this.autoLabel15.Text = "Trạng thái";
            this.autoLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel15.ThemeName = "Office2016Colorful";
            // 
            // cboStatus
            // 
            this.cboStatus.AllowDropDownResize = false;
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.BackColor = System.Drawing.Color.White;
            this.cboStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboStatus.Location = new System.Drawing.Point(123, 47);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(255, 26);
            this.cboStatus.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cboStatus.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.cboStatus.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStatus.TabIndex = 4;
            this.cboStatus.TabStop = false;
            this.cboStatus.ThemeName = "Office2016Colorful";
            // 
            // RoomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomTabControl);
            this.Name = "RoomPage";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.RoomPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomTabControl)).EndInit();
            this.roomTabControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGrid)).EndInit();
            this.addPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv roomTabControl;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv listPage;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addPage;
        private Syncfusion.WinForms.DataGrid.SfDataGrid roomDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtType;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numMax;
        private Syncfusion.WinForms.Controls.SfButton btnTypeAdd;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel13;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel14;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtRoom;
        private Syncfusion.WinForms.ListView.SfComboBox cboType;
        private Syncfusion.WinForms.Controls.SfButton btnRoomAdd;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel15;
        private Syncfusion.WinForms.ListView.SfComboBox cboStatus;
    }
}