﻿namespace Hotel_Management.Pages
{
    partial class EmployeePage
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
            this.employeeTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.listPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.employeeDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.addPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtFulName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtUniqueNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cboGender = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtPosition = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dDoB = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.txtPhone = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnAdd = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTabControl)).BeginInit();
            this.employeeTabControl.SuspendLayout();
            this.listPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).BeginInit();
            this.addPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFulName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUniqueNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeTabControl
            // 
            this.employeeTabControl.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.employeeTabControl.BeforeTouchSize = new System.Drawing.Size(798, 448);
            this.employeeTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeTabControl.BorderVisible = true;
            this.employeeTabControl.Controls.Add(this.listPage);
            this.employeeTabControl.Controls.Add(this.addPage);
            this.employeeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTabControl.Location = new System.Drawing.Point(2, 2);
            this.employeeTabControl.Name = "employeeTabControl";
            this.employeeTabControl.RotateTextWhenVertical = true;
            this.employeeTabControl.Size = new System.Drawing.Size(798, 448);
            this.employeeTabControl.TabIndex = 0;
            this.employeeTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            this.employeeTabControl.ThemeName = "TabRendererOffice2016White";
            this.employeeTabControl.ThemesEnabled = true;
            // 
            // listPage
            // 
            this.listPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPage.Controls.Add(this.employeeDataGrid);
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
            this.listPage.ThemesEnabled = true;
            this.listPage.Enter += new System.EventHandler(this.listPage_Enter);
            // 
            // employeeDataGrid
            // 
            this.employeeDataGrid.AccessibleName = "Table";
            this.employeeDataGrid.AllowEditing = false;
            this.employeeDataGrid.AllowFiltering = true;
            this.employeeDataGrid.AllowResizingColumns = true;
            this.employeeDataGrid.AutoGenerateColumns = false;
            this.employeeDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.employeeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGrid.Location = new System.Drawing.Point(0, 0);
            this.employeeDataGrid.Name = "employeeDataGrid";
            this.employeeDataGrid.Size = new System.Drawing.Size(794, 420);
            this.employeeDataGrid.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeDataGrid.Style.CellStyle.Font.Size = 10F;
            this.employeeDataGrid.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.employeeDataGrid.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.employeeDataGrid.Style.HeaderStyle.Font.Size = 10F;
            this.employeeDataGrid.TabIndex = 0;
            this.employeeDataGrid.Text = "sfDataGrid1";
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
            this.addPage.ThemesEnabled = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.autoLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel7, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFulName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUniqueNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboGender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPosition, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dDoB, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel1.Location = new System.Drawing.Point(3, 10);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(114, 20);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Họ tên";
            this.autoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel1.ThemeName = "Office2016Colorful";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel2.Location = new System.Drawing.Point(3, 50);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(114, 20);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "Mã căn cước";
            this.autoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel2.ThemeName = "Office2016Colorful";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel3.Location = new System.Drawing.Point(3, 90);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(114, 20);
            this.autoLabel3.TabIndex = 2;
            this.autoLabel3.Text = "Giới tính";
            this.autoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel3.ThemeName = "Office2016Colorful";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel4.Location = new System.Drawing.Point(3, 130);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(114, 20);
            this.autoLabel4.TabIndex = 3;
            this.autoLabel4.Text = "Chức vụ";
            this.autoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel4.ThemeName = "Office2016Colorful";
            // 
            // autoLabel5
            // 
            this.autoLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel5.Location = new System.Drawing.Point(410, 10);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(114, 20);
            this.autoLabel5.TabIndex = 4;
            this.autoLabel5.Text = "Ngày sinh";
            this.autoLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel5.ThemeName = "Office2016Colorful";
            // 
            // autoLabel6
            // 
            this.autoLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel6.Location = new System.Drawing.Point(410, 50);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(114, 20);
            this.autoLabel6.TabIndex = 5;
            this.autoLabel6.Text = "Số điện thoại";
            this.autoLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel6.ThemeName = "Office2016Colorful";
            // 
            // autoLabel7
            // 
            this.autoLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel7.Location = new System.Drawing.Point(410, 90);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(114, 20);
            this.autoLabel7.TabIndex = 6;
            this.autoLabel7.Text = "Địa chỉ";
            this.autoLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel7.ThemeName = "Office2016Colorful";
            // 
            // txtFulName
            // 
            this.txtFulName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFulName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFulName.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtFulName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtFulName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFulName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFulName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtFulName.Location = new System.Drawing.Point(123, 7);
            this.txtFulName.Name = "txtFulName";
            this.txtFulName.Size = new System.Drawing.Size(261, 26);
            this.txtFulName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtFulName.TabIndex = 7;
            this.txtFulName.ThemeName = "Office2016Colorful";
            // 
            // txtUniqueNumber
            // 
            this.txtUniqueNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniqueNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUniqueNumber.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtUniqueNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtUniqueNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUniqueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniqueNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtUniqueNumber.Location = new System.Drawing.Point(123, 47);
            this.txtUniqueNumber.Name = "txtUniqueNumber";
            this.txtUniqueNumber.Size = new System.Drawing.Size(261, 26);
            this.txtUniqueNumber.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtUniqueNumber.TabIndex = 8;
            this.txtUniqueNumber.ThemeName = "Office2016Colorful";
            // 
            // cboGender
            // 
            this.cboGender.AllowDropDownResize = false;
            this.cboGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGender.BackColor = System.Drawing.Color.White;
            this.cboGender.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboGender.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboGender.Location = new System.Drawing.Point(123, 87);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(261, 26);
            this.cboGender.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboGender.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.cboGender.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboGender.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGender.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboGender.TabIndex = 9;
            this.cboGender.ThemeName = "Office2016Colorful";
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPosition.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtPosition.Location = new System.Drawing.Point(123, 127);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(261, 26);
            this.txtPosition.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtPosition.TabIndex = 10;
            this.txtPosition.ThemeName = "Office2016Colorful";
            // 
            // dDoB
            // 
            this.dDoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dDoB.Cursor = System.Windows.Forms.Cursors.Default;
            this.dDoB.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.dDoB.DateTimeIcon = null;
            this.dDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dDoB.Location = new System.Drawing.Point(530, 6);
            this.dDoB.Name = "dDoB";
            this.dDoB.Size = new System.Drawing.Size(261, 28);
            this.dDoB.TabIndex = 11;
            this.dDoB.ThemeName = "Office2016Colorful";
            this.dDoB.ToolTipText = "";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPhone.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtPhone.Location = new System.Drawing.Point(530, 47);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(261, 26);
            this.txtPhone.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtPhone.TabIndex = 12;
            this.txtPhone.ThemeName = "Office2016Colorful";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtAddress.Location = new System.Drawing.Point(530, 87);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(261, 26);
            this.txtAddress.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtAddress.TabIndex = 13;
            this.txtAddress.ThemeName = "Office2016Colorful";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(530, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(261, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.ThemeName = "Office2016Colorful";
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeTabControl);
            this.Name = "EmployeePage";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.Style.InactiveShadowOpacity = ((byte)(0));
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTabControl)).EndInit();
            this.employeeTabControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).EndInit();
            this.addPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFulName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUniqueNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv employeeTabControl;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv listPage;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addPage;
        private Syncfusion.WinForms.DataGrid.SfDataGrid employeeDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFulName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUniqueNumber;
        private Syncfusion.WinForms.ListView.SfComboBox cboGender;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPosition;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dDoB;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPhone;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAddress;
        private Syncfusion.WinForms.Controls.SfButton btnAdd;
    }
}