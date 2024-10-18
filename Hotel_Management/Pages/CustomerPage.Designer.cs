namespace Hotel_Management.Pages
{
    partial class CustomerPage
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
            this.customerTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.listPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.customerDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.addPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCustomerName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCustomerUnique = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCustomerPhone = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cboCustomerGender = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboCustomerNationaity = new Syncfusion.WinForms.ListView.SfComboBox();
            this.sfDateTimeEdit1 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnAddCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCustomerClear = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerTabControl)).BeginInit();
            this.customerTabControl.SuspendLayout();
            this.listPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.addPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerUnique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerNationaity)).BeginInit();
            this.SuspendLayout();
            // 
            // customerTabControl
            // 
            this.customerTabControl.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customerTabControl.BeforeTouchSize = new System.Drawing.Size(798, 448);
            this.customerTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerTabControl.BorderVisible = true;
            this.customerTabControl.Controls.Add(this.listPage);
            this.customerTabControl.Controls.Add(this.addPage);
            this.customerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTabControl.Location = new System.Drawing.Point(2, 2);
            this.customerTabControl.Name = "customerTabControl";
            this.customerTabControl.RotateTextWhenVertical = true;
            this.customerTabControl.Size = new System.Drawing.Size(798, 448);
            this.customerTabControl.TabIndex = 1;
            this.customerTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            this.customerTabControl.ThemeName = "TabRendererOffice2016White";
            this.customerTabControl.ThemesEnabled = true;
            // 
            // listPage
            // 
            this.listPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPage.Controls.Add(this.customerDataGrid);
            this.listPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listPage.Image = null;
            this.listPage.ImageSize = new System.Drawing.Size(16, 16);
            this.listPage.Location = new System.Drawing.Point(2, 26);
            this.listPage.Margin = new System.Windows.Forms.Padding(0);
            this.listPage.Name = "listPage";
            this.listPage.ShowCloseButton = true;
            this.listPage.Size = new System.Drawing.Size(794, 420);
            this.listPage.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPage.TabIndex = 1;
            this.listPage.Text = "Danh sách";
            this.listPage.ThemesEnabled = true;
            this.listPage.Enter += new System.EventHandler(this.listPage_Enter);
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AccessibleName = "Table";
            this.customerDataGrid.AllowEditing = false;
            this.customerDataGrid.AllowFiltering = true;
            this.customerDataGrid.AllowResizingColumns = true;
            this.customerDataGrid.AutoGenerateColumns = false;
            this.customerDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.customerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGrid.Location = new System.Drawing.Point(0, 0);
            this.customerDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.customerDataGrid.PreviewRowHeight = 42;
            this.customerDataGrid.Size = new System.Drawing.Size(794, 420);
            this.customerDataGrid.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerDataGrid.Style.CellStyle.Font.Size = 10F;
            this.customerDataGrid.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerDataGrid.Style.HeaderStyle.Font.Size = 10F;
            this.customerDataGrid.TabIndex = 0;
            this.customerDataGrid.Text = "sfDataGrid2";
            // 
            // addPage
            // 
            this.addPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addPage.Controls.Add(this.tableLayoutPanel1);
            this.addPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.addPage.Enter += new System.EventHandler(this.addPage_Enter);
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
            this.tableLayoutPanel1.Controls.Add(this.autoLabel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.autoLabel6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerUnique, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerPhone, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboCustomerGender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboCustomerNationaity, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.sfDateTimeEdit1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddCustomer, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCustomerClear, 1, 3);
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
            this.autoLabel2.Text = "Mã định danh";
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
            this.autoLabel4.Location = new System.Drawing.Point(410, 10);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(114, 20);
            this.autoLabel4.TabIndex = 3;
            this.autoLabel4.Text = "Ngày sinh";
            this.autoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel4.ThemeName = "Office2016Colorful";
            // 
            // autoLabel5
            // 
            this.autoLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel5.Location = new System.Drawing.Point(410, 50);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(114, 20);
            this.autoLabel5.TabIndex = 4;
            this.autoLabel5.Text = "Số điện thoại";
            this.autoLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel5.ThemeName = "Office2016Colorful";
            // 
            // autoLabel6
            // 
            this.autoLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel6.Location = new System.Drawing.Point(410, 90);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(114, 20);
            this.autoLabel6.TabIndex = 5;
            this.autoLabel6.Text = "Quốc tịch";
            this.autoLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel6.ThemeName = "Office2016Colorful";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerName.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtCustomerName.Location = new System.Drawing.Point(123, 7);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(261, 26);
            this.txtCustomerName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.ThemeName = "Office2016Colorful";
            // 
            // txtCustomerUnique
            // 
            this.txtCustomerUnique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerUnique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerUnique.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtCustomerUnique.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtCustomerUnique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerUnique.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerUnique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtCustomerUnique.Location = new System.Drawing.Point(123, 47);
            this.txtCustomerUnique.Name = "txtCustomerUnique";
            this.txtCustomerUnique.Size = new System.Drawing.Size(261, 26);
            this.txtCustomerUnique.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtCustomerUnique.TabIndex = 2;
            this.txtCustomerUnique.ThemeName = "Office2016Colorful";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCustomerPhone.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtCustomerPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtCustomerPhone.Location = new System.Drawing.Point(530, 47);
            this.txtCustomerPhone.MaxLength = 10;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(261, 26);
            this.txtCustomerPhone.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtCustomerPhone.TabIndex = 5;
            this.txtCustomerPhone.ThemeName = "Office2016Colorful";
            this.txtCustomerPhone.TextChanged += new System.EventHandler(this.txtCustomerPhone_TextChanged);
            this.txtCustomerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerPhone_KeyPress);
            // 
            // cboCustomerGender
            // 
            this.cboCustomerGender.AllowDropDownResize = false;
            this.cboCustomerGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCustomerGender.BackColor = System.Drawing.Color.White;
            this.cboCustomerGender.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboCustomerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerGender.Location = new System.Drawing.Point(123, 87);
            this.cboCustomerGender.Name = "cboCustomerGender";
            this.cboCustomerGender.Size = new System.Drawing.Size(261, 26);
            this.cboCustomerGender.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cboCustomerGender.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerGender.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.cboCustomerGender.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerGender.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCustomerGender.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerGender.TabIndex = 3;
            this.cboCustomerGender.TabStop = false;
            this.cboCustomerGender.ThemeName = "Office2016Colorful";
            // 
            // cboCustomerNationaity
            // 
            this.cboCustomerNationaity.AllowDropDownResize = false;
            this.cboCustomerNationaity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCustomerNationaity.BackColor = System.Drawing.Color.White;
            this.cboCustomerNationaity.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboCustomerNationaity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerNationaity.Location = new System.Drawing.Point(530, 87);
            this.cboCustomerNationaity.Name = "cboCustomerNationaity";
            this.cboCustomerNationaity.Size = new System.Drawing.Size(261, 26);
            this.cboCustomerNationaity.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cboCustomerNationaity.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerNationaity.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.cboCustomerNationaity.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerNationaity.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCustomerNationaity.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerNationaity.TabIndex = 6;
            this.cboCustomerNationaity.TabStop = false;
            this.cboCustomerNationaity.ThemeName = "Office2016Colorful";
            // 
            // sfDateTimeEdit1
            // 
            this.sfDateTimeEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDateTimeEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sfDateTimeEdit1.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.sfDateTimeEdit1.DateTimeIcon = null;
            this.sfDateTimeEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfDateTimeEdit1.Location = new System.Drawing.Point(530, 6);
            this.sfDateTimeEdit1.Name = "sfDateTimeEdit1";
            this.sfDateTimeEdit1.Size = new System.Drawing.Size(261, 28);
            this.sfDateTimeEdit1.TabIndex = 4;
            this.sfDateTimeEdit1.ThemeName = "Office2016Colorful";
            this.sfDateTimeEdit1.ToolTipText = "";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.AutoSize = true;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddCustomer.Location = new System.Drawing.Point(530, 124);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnAddCustomer.Size = new System.Drawing.Size(261, 31);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Tag = "0";
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.ThemeName = "Office2016Colorful";
            // 
            // btnCustomerClear
            // 
            this.btnCustomerClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerClear.Location = new System.Drawing.Point(123, 126);
            this.btnCustomerClear.Name = "btnCustomerClear";
            this.btnCustomerClear.Size = new System.Drawing.Size(261, 28);
            this.btnCustomerClear.TabIndex = 8;
            this.btnCustomerClear.Text = "Xoá";
            this.btnCustomerClear.ThemeName = "Office2016Colorful";
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerTabControl);
            this.Name = "CustomerPage";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.Style.InactiveShadowOpacity = ((byte)(0));
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerTabControl)).EndInit();
            this.customerTabControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.addPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerUnique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerNationaity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv customerTabControl;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv listPage;
        private Syncfusion.WinForms.DataGrid.SfDataGrid customerDataGrid;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv addPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomerName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomerUnique;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCustomerPhone;
        private Syncfusion.WinForms.ListView.SfComboBox cboCustomerGender;
        private Syncfusion.WinForms.ListView.SfComboBox cboCustomerNationaity;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTimeEdit1;
        private Syncfusion.WinForms.Controls.SfButton btnAddCustomer;
        private Syncfusion.WinForms.Controls.SfButton btnCustomerClear;
    }
}