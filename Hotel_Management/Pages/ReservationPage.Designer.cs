namespace Hotel_Management.Pages
{
    partial class ReservationPage
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
            this.reservationTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.listPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.reservationDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.addPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfComboBox1 = new Syncfusion.WinForms.ListView.SfComboBox();
            this.sfDateTimeEdit2 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfDateTimeEdit3 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.reservationTabControl)).BeginInit();
            this.reservationTabControl.SuspendLayout();
            this.listPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).BeginInit();
            this.addPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationTabControl
            // 
            this.reservationTabControl.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reservationTabControl.BeforeTouchSize = new System.Drawing.Size(800, 450);
            this.reservationTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reservationTabControl.BorderVisible = true;
            this.reservationTabControl.Controls.Add(this.listPage);
            this.reservationTabControl.Controls.Add(this.addPage);
            this.reservationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationTabControl.Location = new System.Drawing.Point(0, 0);
            this.reservationTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.reservationTabControl.Name = "reservationTabControl";
            this.reservationTabControl.RotateTextWhenVertical = true;
            this.reservationTabControl.Size = new System.Drawing.Size(800, 450);
            this.reservationTabControl.TabIndex = 1;
            this.reservationTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            this.reservationTabControl.ThemeName = "TabRendererOffice2016White";
            this.reservationTabControl.ThemesEnabled = true;
            // 
            // listPage
            // 
            this.listPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPage.Controls.Add(this.reservationDataGrid);
            this.listPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listPage.Image = null;
            this.listPage.ImageSize = new System.Drawing.Size(16, 16);
            this.listPage.Location = new System.Drawing.Point(2, 26);
            this.listPage.Name = "listPage";
            this.listPage.ShowCloseButton = true;
            this.listPage.Size = new System.Drawing.Size(796, 422);
            this.listPage.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPage.TabIndex = 1;
            this.listPage.Text = "Danh sách";
            this.listPage.ThemesEnabled = true;
            this.listPage.Enter += new System.EventHandler(this.listPage_Enter);
            // 
            // reservationDataGrid
            // 
            this.reservationDataGrid.AccessibleName = "Table";
            this.reservationDataGrid.AllowEditing = false;
            this.reservationDataGrid.AllowFiltering = true;
            this.reservationDataGrid.AllowResizingColumns = true;
            this.reservationDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.reservationDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationDataGrid.Location = new System.Drawing.Point(0, 0);
            this.reservationDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.reservationDataGrid.Name = "reservationDataGrid";
            this.reservationDataGrid.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.reservationDataGrid.PreviewRowHeight = 42;
            this.reservationDataGrid.Size = new System.Drawing.Size(796, 422);
            this.reservationDataGrid.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationDataGrid.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.reservationDataGrid.TabIndex = 0;
            this.reservationDataGrid.Text = "sfDataGrid1";
            // 
            // addPage
            // 
            this.addPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addPage.Controls.Add(this.tableLayoutPanel2);
            this.addPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.addPage.Image = null;
            this.addPage.ImageSize = new System.Drawing.Size(16, 16);
            this.addPage.Location = new System.Drawing.Point(2, 26);
            this.addPage.Name = "addPage";
            this.addPage.ShowCloseButton = true;
            this.addPage.Size = new System.Drawing.Size(796, 422);
            this.addPage.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPage.TabIndex = 2;
            this.addPage.Text = "Thêm";
            this.addPage.ThemesEnabled = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.autoLabel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel9, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.sfComboBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sfDateTimeEdit2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.sfDateTimeEdit3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.sfButton1, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(796, 422);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // autoLabel7
            // 
            this.autoLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel7.Location = new System.Drawing.Point(3, 14);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(114, 20);
            this.autoLabel7.TabIndex = 0;
            this.autoLabel7.Text = "Phòng";
            this.autoLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel7.ThemeName = "Office2016Colorful";
            // 
            // autoLabel8
            // 
            this.autoLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel8.Location = new System.Drawing.Point(3, 52);
            this.autoLabel8.Name = "autoLabel8";
            this.autoLabel8.Size = new System.Drawing.Size(114, 40);
            this.autoLabel8.TabIndex = 1;
            this.autoLabel8.Text = "Ngày trả phòng dự kiến";
            this.autoLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel8.ThemeName = "Office2016Colorful";
            // 
            // autoLabel9
            // 
            this.autoLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel9.Location = new System.Drawing.Point(411, 4);
            this.autoLabel9.Name = "autoLabel9";
            this.autoLabel9.Size = new System.Drawing.Size(114, 40);
            this.autoLabel9.TabIndex = 2;
            this.autoLabel9.Text = "Ngày nhận phòng";
            this.autoLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel9.ThemeName = "Office2016Colorful";
            // 
            // sfComboBox1
            // 
            this.sfComboBox1.AllowDropDownResize = false;
            this.sfComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sfComboBox1.BackColor = System.Drawing.Color.White;
            this.sfComboBox1.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.sfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sfComboBox1.Location = new System.Drawing.Point(123, 11);
            this.sfComboBox1.Name = "sfComboBox1";
            this.sfComboBox1.Size = new System.Drawing.Size(262, 26);
            this.sfComboBox1.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBox1.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sfComboBox1.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBox1.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sfComboBox1.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox1.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sfComboBox1.TabIndex = 3;
            // 
            // sfDateTimeEdit2
            // 
            this.sfDateTimeEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDateTimeEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.sfDateTimeEdit2.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.sfDateTimeEdit2.DateTimeIcon = null;
            this.sfDateTimeEdit2.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            this.sfDateTimeEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateTimeEdit2.Format = "dd/MM/yyyy HH:mm";
            this.sfDateTimeEdit2.Location = new System.Drawing.Point(531, 10);
            this.sfDateTimeEdit2.Name = "sfDateTimeEdit2";
            this.sfDateTimeEdit2.Size = new System.Drawing.Size(262, 28);
            this.sfDateTimeEdit2.TabIndex = 4;
            this.sfDateTimeEdit2.ThemeName = "Office2016Colorful";
            this.sfDateTimeEdit2.ToolTipText = "";
            // 
            // sfDateTimeEdit3
            // 
            this.sfDateTimeEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDateTimeEdit3.Cursor = System.Windows.Forms.Cursors.Default;
            this.sfDateTimeEdit3.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.sfDateTimeEdit3.DateTimeIcon = null;
            this.sfDateTimeEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateTimeEdit3.Location = new System.Drawing.Point(123, 58);
            this.sfDateTimeEdit3.Name = "sfDateTimeEdit3";
            this.sfDateTimeEdit3.Size = new System.Drawing.Size(262, 28);
            this.sfDateTimeEdit3.TabIndex = 5;
            this.sfDateTimeEdit3.ThemeName = "Office2016Colorful";
            this.sfDateTimeEdit3.ToolTipText = "";
            // 
            // sfButton1
            // 
            this.sfButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sfButton1.AutoSize = true;
            this.sfButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sfButton1.Location = new System.Drawing.Point(531, 56);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.sfButton1.Size = new System.Drawing.Size(262, 31);
            this.sfButton1.TabIndex = 6;
            this.sfButton1.Text = "Thêm";
            this.sfButton1.ThemeName = "Office2016Colorful";
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reservationTabControl);
            this.Name = "ReservationPage";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Style.InactiveShadowOpacity = ((byte)(0));
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.ReservationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationTabControl)).EndInit();
            this.reservationTabControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGrid)).EndInit();
            this.addPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv reservationTabControl;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv listPage;
        private Syncfusion.WinForms.DataGrid.SfDataGrid reservationDataGrid;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTimeEdit2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTimeEdit3;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
    }
}