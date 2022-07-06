namespace SalesManagmentSystem2.PL
{
    partial class Frm_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Supplier));
            this.Page_supplier = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.refresh_supp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete_supp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit_supp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add_supp = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.address_client = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.email_client = new System.Windows.Forms.MaskedTextBox();
            this.phone_client = new System.Windows.Forms.MaskedTextBox();
            this.name_client = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.Page_supplier.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page_supplier
            // 
            this.Page_supplier.Controls.Add(this.panel5);
            this.Page_supplier.Controls.Add(this.panel1);
            this.Page_supplier.Controls.Add(this.panel2);
            this.Page_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page_supplier.Location = new System.Drawing.Point(0, 0);
            this.Page_supplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Page_supplier.Name = "Page_supplier";
            this.Page_supplier.Size = new System.Drawing.Size(1276, 812);
            this.Page_supplier.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(857, 812);
            this.panel5.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(857, 812);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colAddress,
            this.colPhone,
            this.colMail});
            this.gridView1.DetailHeight = 431;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsSelection.CheckBoxSelectorField = "ID";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 29;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 111;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 29;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 1;
            this.colAddress.Width = 111;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 29;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            this.colPhone.Width = 111;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.MinWidth = 29;
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 3;
            this.colMail.Width = 111;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(857, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 812);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.refresh_supp);
            this.panel4.Controls.Add(this.btn_delete_supp);
            this.panel4.Controls.Add(this.btn_edit_supp);
            this.panel4.Controls.Add(this.btn_add_supp);
            this.panel4.Location = new System.Drawing.Point(-9, 486);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 326);
            this.panel4.TabIndex = 5;
            // 
            // refresh_supp
            // 
            this.refresh_supp.Appearance.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_supp.Appearance.Options.UseFont = true;
            this.refresh_supp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refresh_supp.ImageOptions.Image")));
            this.refresh_supp.Location = new System.Drawing.Point(239, 144);
            this.refresh_supp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refresh_supp.Name = "refresh_supp";
            this.refresh_supp.Size = new System.Drawing.Size(181, 87);
            this.refresh_supp.TabIndex = 7;
            this.refresh_supp.Text = "تحديث";
            this.refresh_supp.Click += new System.EventHandler(this.refresh_supp_Click);
            // 
            // btn_delete_supp
            // 
            this.btn_delete_supp.Appearance.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_supp.Appearance.Options.UseFont = true;
            this.btn_delete_supp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_supp.ImageOptions.Image")));
            this.btn_delete_supp.Location = new System.Drawing.Point(239, 30);
            this.btn_delete_supp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete_supp.Name = "btn_delete_supp";
            this.btn_delete_supp.Size = new System.Drawing.Size(180, 87);
            this.btn_delete_supp.TabIndex = 6;
            this.btn_delete_supp.Text = "حذف";
            this.btn_delete_supp.Click += new System.EventHandler(this.btn_delete_supp_Click);
            // 
            // btn_edit_supp
            // 
            this.btn_edit_supp.Appearance.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_supp.Appearance.Options.UseFont = true;
            this.btn_edit_supp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit_supp.ImageOptions.Image")));
            this.btn_edit_supp.Location = new System.Drawing.Point(13, 144);
            this.btn_edit_supp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit_supp.Name = "btn_edit_supp";
            this.btn_edit_supp.Size = new System.Drawing.Size(217, 87);
            this.btn_edit_supp.TabIndex = 5;
            this.btn_edit_supp.Text = "تعديل";
            this.btn_edit_supp.Click += new System.EventHandler(this.btn_edit_supp_Click);
            // 
            // btn_add_supp
            // 
            this.btn_add_supp.Appearance.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_supp.Appearance.Options.UseFont = true;
            this.btn_add_supp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_supp.ImageOptions.Image")));
            this.btn_add_supp.Location = new System.Drawing.Point(13, 30);
            this.btn_add_supp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add_supp.Name = "btn_add_supp";
            this.btn_add_supp.Size = new System.Drawing.Size(217, 87);
            this.btn_add_supp.TabIndex = 4;
            this.btn_add_supp.Text = "اضافة";
            this.btn_add_supp.Click += new System.EventHandler(this.btn_add_supp_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.address_client);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.email_client);
            this.panel3.Controls.Add(this.phone_client);
            this.panel3.Controls.Add(this.name_client);
            this.panel3.Location = new System.Drawing.Point(-9, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 479);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // address_client
            // 
            this.address_client.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_client.Location = new System.Drawing.Point(25, 345);
            this.address_client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.address_client.Multiline = true;
            this.address_client.Name = "address_client";
            this.address_client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address_client.Size = new System.Drawing.Size(383, 110);
            this.address_client.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(321, 309);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 25);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "العنوان";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(220, 212);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(157, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "البريد الالكترونى";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(264, 114);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 25);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "رقم التليفون";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(267, 31);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "اسم العميل";
            // 
            // email_client
            // 
            this.email_client.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_client.Location = new System.Drawing.Point(25, 250);
            this.email_client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email_client.Name = "email_client";
            this.email_client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.email_client.Size = new System.Drawing.Size(383, 32);
            this.email_client.TabIndex = 3;
            // 
            // phone_client
            // 
            this.phone_client.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_client.Location = new System.Drawing.Point(25, 153);
            this.phone_client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phone_client.Name = "phone_client";
            this.phone_client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone_client.Size = new System.Drawing.Size(383, 32);
            this.phone_client.TabIndex = 1;
            // 
            // name_client
            // 
            this.name_client.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_client.Location = new System.Drawing.Point(25, 69);
            this.name_client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_client.Name = "name_client";
            this.name_client.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_client.Size = new System.Drawing.Size(383, 32);
            this.name_client.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 0;
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            // 
            // Frm_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 812);
            this.Controls.Add(this.Page_supplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Supplier";
            this.Text = "Frm_Supplier";
            this.TopMost = true;
            this.Page_supplier.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel Page_supplier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox email_client;
        private System.Windows.Forms.MaskedTextBox phone_client;
        private System.Windows.Forms.TextBox name_client;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton refresh_supp;
        private DevExpress.XtraEditors.SimpleButton btn_delete_supp;
        private DevExpress.XtraEditors.SimpleButton btn_edit_supp;
        private DevExpress.XtraEditors.SimpleButton btn_add_supp;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox address_client;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
    }
}