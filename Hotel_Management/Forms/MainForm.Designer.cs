namespace Hotel_Management.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabbedMDI = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager(this.components);
            this.SuspendLayout();
            // 
            // tabbedMDI
            // 
            this.tabbedMDI.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbedMDI.AllowTabGroupCustomizing = false;
            this.tabbedMDI.AttachedTo = this;
            this.tabbedMDI.CanOverrideStyle = true;
            this.tabbedMDI.CloseButtonBackColor = System.Drawing.Color.White;
            this.tabbedMDI.CloseButtonToolTip = "";
            this.tabbedMDI.CloseButtonVisible = false;
            this.tabbedMDI.DropDownButtonToolTip = "";
            this.tabbedMDI.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDI.NeedUpdateHostedForm = false;
            this.tabbedMDI.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbedMDI.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016White);
            this.tabbedMDI.ThemeName = "TabRendererOffice2016White";
            this.tabbedMDI.ThemesEnabled = true;
            this.tabbedMDI.UseIconsInTabs = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CanOverrideStyle = true;
            this.ClientSize = new System.Drawing.Size(844, 541);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(860, 580);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.InactiveShadowOpacity = ((byte)(0));
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.ShadowOpacity = ((byte)(0));
            this.Style.TitleBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Quản lý khách sạn";
            this.ThemeName = "Office2016Colorful";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDI;
    }
}