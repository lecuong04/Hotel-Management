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
            this.dDoB = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClear = new Syncfusion.WinForms.Controls.SfButton();
            this.modPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel13 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cboCustomer = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtModFulName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtModUnique = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cboModGender = new Syncfusion.WinForms.ListView.SfComboBox();
            this.dModDoB = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.txtModPhone = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cboModNationality = new Syncfusion.WinForms.ListView.SfComboBox();
            this.btnMod = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
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
            this.modPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModFulName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModUnique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboModGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboModNationality)).BeginInit();
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
            this.customerTabControl.Controls.Add(this.modPage);
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
            this.tableLayoutPanel1.Controls.Add(this.dDoB, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 3);
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
            this.dDoB.TabIndex = 4;
            this.dDoB.ThemeName = "Office2016Colorful";
            this.dDoB.ToolTipText = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(530, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnAdd.Size = new System.Drawing.Size(261, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Tag = "0";
            this.btnAdd.Text = "Thêm";
            this.btnAdd.ThemeName = "Office2016Colorful";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(123, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(261, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Xoá";
            this.btnClear.ThemeName = "Office2016Colorful";
            // 
            // modPage
            // 
            this.modPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modPage.Controls.Add(this.tableLayoutPanel2);
            this.modPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.modPage.Image = null;
            this.modPage.ImageSize = new System.Drawing.Size(16, 16);
            this.modPage.Location = new System.Drawing.Point(2, 26);
            this.modPage.Name = "modPage";
            this.modPage.ShowCloseButton = true;
            this.modPage.Size = new System.Drawing.Size(794, 420);
            this.modPage.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPage.TabIndex = 3;
            this.modPage.Text = "Sửa";
            this.modPage.ThemesEnabled = true;
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
            this.tableLayoutPanel2.Controls.Add(this.autoLabel8, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel9, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel10, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel11, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel12, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel13, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.cboCustomer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtModFulName, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtModUnique, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboModGender, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.dModDoB, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtModPhone, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.cboModNationality, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnMod, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 420);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // autoLabel7
            // 
            this.autoLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel7.Location = new System.Drawing.Point(3, 10);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(114, 20);
            this.autoLabel7.TabIndex = 0;
            this.autoLabel7.Text = "Khách hàng";
            this.autoLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel7.ThemeName = "Office2016Colorful";
            // 
            // autoLabel8
            // 
            this.autoLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel8.Location = new System.Drawing.Point(410, 10);
            this.autoLabel8.Name = "autoLabel8";
            this.autoLabel8.Size = new System.Drawing.Size(114, 20);
            this.autoLabel8.TabIndex = 1;
            this.autoLabel8.Text = "Họ tên";
            this.autoLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel8.ThemeName = "Office2016Colorful";
            // 
            // autoLabel9
            // 
            this.autoLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel9.Location = new System.Drawing.Point(410, 50);
            this.autoLabel9.Name = "autoLabel9";
            this.autoLabel9.Size = new System.Drawing.Size(114, 20);
            this.autoLabel9.TabIndex = 2;
            this.autoLabel9.Text = "Mã định danh";
            this.autoLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel9.ThemeName = "Office2016Colorful";
            // 
            // autoLabel10
            // 
            this.autoLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel10.Location = new System.Drawing.Point(410, 90);
            this.autoLabel10.Name = "autoLabel10";
            this.autoLabel10.Size = new System.Drawing.Size(114, 20);
            this.autoLabel10.TabIndex = 3;
            this.autoLabel10.Text = "Giới tính";
            this.autoLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel10.ThemeName = "Office2016Colorful";
            // 
            // autoLabel11
            // 
            this.autoLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel11.Location = new System.Drawing.Point(410, 130);
            this.autoLabel11.Name = "autoLabel11";
            this.autoLabel11.Size = new System.Drawing.Size(114, 20);
            this.autoLabel11.TabIndex = 4;
            this.autoLabel11.Text = "Ngày sinh";
            this.autoLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel11.ThemeName = "Office2016Colorful";
            // 
            // autoLabel12
            // 
            this.autoLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel12.Location = new System.Drawing.Point(410, 170);
            this.autoLabel12.Name = "autoLabel12";
            this.autoLabel12.Size = new System.Drawing.Size(114, 20);
            this.autoLabel12.TabIndex = 5;
            this.autoLabel12.Text = "Số điện thoại";
            this.autoLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel12.ThemeName = "Office2016Colorful";
            // 
            // autoLabel13
            // 
            this.autoLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel13.Location = new System.Drawing.Point(410, 210);
            this.autoLabel13.Name = "autoLabel13";
            this.autoLabel13.Size = new System.Drawing.Size(114, 20);
            this.autoLabel13.TabIndex = 6;
            this.autoLabel13.Text = "Quốc tịch";
            this.autoLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoLabel13.ThemeName = "Office2016Colorful";
            // 
            // cboCustomer
            // 
            this.cboCustomer.AllowDropDownResize = false;
            this.cboCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCustomer.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.Location = new System.Drawing.Point(123, 7);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(261, 26);
            this.cboCustomer.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCustomer.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.TabIndex = 7;
            this.cboCustomer.TabStop = false;
            this.cboCustomer.ThemeName = "Office2016Colorful";
            // 
            // txtModFulName
            // 
            this.txtModFulName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModFulName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtModFulName.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtModFulName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtModFulName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModFulName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModFulName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtModFulName.Location = new System.Drawing.Point(530, 7);
            this.txtModFulName.Name = "txtModFulName";
            this.txtModFulName.Size = new System.Drawing.Size(261, 26);
            this.txtModFulName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtModFulName.TabIndex = 9;
            this.txtModFulName.ThemeName = "Office2016Colorful";
            // 
            // txtModUnique
            // 
            this.txtModUnique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModUnique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtModUnique.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtModUnique.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtModUnique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModUnique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtModUnique.Location = new System.Drawing.Point(530, 47);
            this.txtModUnique.Name = "txtModUnique";
            this.txtModUnique.Size = new System.Drawing.Size(261, 26);
            this.txtModUnique.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtModUnique.TabIndex = 10;
            this.txtModUnique.ThemeName = "Office2016Colorful";
            // 
            // cboModGender
            // 
            this.cboModGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboModGender.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboModGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModGender.Location = new System.Drawing.Point(530, 87);
            this.cboModGender.Name = "cboModGender";
            this.cboModGender.Size = new System.Drawing.Size(261, 26);
            this.cboModGender.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModGender.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModGender.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboModGender.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModGender.TabIndex = 11;
            this.cboModGender.TabStop = false;
            this.cboModGender.ThemeName = "Office2016Colorful";
            // 
            // dModDoB
            // 
            this.dModDoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dModDoB.DateTimeIcon = null;
            this.dModDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dModDoB.Location = new System.Drawing.Point(530, 126);
            this.dModDoB.Name = "dModDoB";
            this.dModDoB.Size = new System.Drawing.Size(261, 28);
            this.dModDoB.TabIndex = 12;
            this.dModDoB.ThemeName = "Office2016Colorful";
            this.dModDoB.ToolTipText = "";
            // 
            // txtModPhone
            // 
            this.txtModPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtModPhone.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.txtModPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtModPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtModPhone.Location = new System.Drawing.Point(530, 167);
            this.txtModPhone.Name = "txtModPhone";
            this.txtModPhone.Size = new System.Drawing.Size(261, 26);
            this.txtModPhone.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.txtModPhone.TabIndex = 13;
            this.txtModPhone.ThemeName = "Office2016Colorful";
            // 
            // cboModNationality
            // 
            this.cboModNationality.AllowDropDownResize = false;
            this.cboModNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboModNationality.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboModNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModNationality.Location = new System.Drawing.Point(530, 207);
            this.cboModNationality.Name = "cboModNationality";
            this.cboModNationality.Size = new System.Drawing.Size(261, 26);
            this.cboModNationality.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModNationality.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModNationality.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboModNationality.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModNationality.TabIndex = 14;
            this.cboModNationality.TabStop = false;
            this.cboModNationality.ThemeName = "Office2016Colorful";
            // 
            // btnMod
            // 
            this.btnMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(123, 46);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(261, 28);
            this.btnMod.TabIndex = 8;
            this.btnMod.Text = "Sửa";
            this.btnMod.ThemeName = "Office2016Colorful";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(530, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(261, 28);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu";
            this.btnSave.ThemeName = "Office2016Colorful";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(123, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(261, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.ThemeName = "Office2016Colorful";
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
            this.modPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModFulName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModUnique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboModGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboModNationality)).EndInit();
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
        private Syncfusion.WinForms.Input.SfDateTimeEdit dDoB;
        private Syncfusion.WinForms.Controls.SfButton btnAdd;
        private Syncfusion.WinForms.Controls.SfButton btnClear;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv modPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel13;
        private Syncfusion.WinForms.ListView.SfComboBox cboCustomer;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtModFulName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtModUnique;
        private Syncfusion.WinForms.ListView.SfComboBox cboModGender;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dModDoB;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtModPhone;
        private Syncfusion.WinForms.ListView.SfComboBox cboModNationality;
        private Syncfusion.WinForms.Controls.SfButton btnMod;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
    }
}