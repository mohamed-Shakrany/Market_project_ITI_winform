namespace SalesManagmentSystem2.PL
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSuppName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Purchasing_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.simpleButton3);
            this.pnlCustomer.Controls.Add(this.simpleButton2);
            this.pnlCustomer.Controls.Add(this.simpleButton1);
            this.pnlCustomer.Controls.Add(this.gridControl1);
            this.pnlCustomer.Controls.Add(this.panel1);
            this.pnlCustomer.Controls.Add(this.label1);
            this.pnlCustomer.Controls.Add(this.textBox2);
            this.pnlCustomer.Controls.Add(this.textBox1);
            this.pnlCustomer.Controls.Add(this.label8);
            this.pnlCustomer.Controls.Add(this.txtUsername);
            this.pnlCustomer.Controls.Add(this.label7);
            this.pnlCustomer.Controls.Add(this.Purchasing_Price);
            this.pnlCustomer.Controls.Add(this.label4);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(941, 621);
            this.pnlCustomer.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(806, 470);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(123, 50);
            this.simpleButton3.TabIndex = 99;
            this.simpleButton3.Text = "حذف";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.SystemColors.GrayText;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(638, 403);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(129, 50);
            this.simpleButton2.TabIndex = 98;
            this.simpleButton2.Text = "تعديل ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.SystemColors.GrayText;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(773, 403);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(156, 50);
            this.simpleButton1.TabIndex = 97;
            this.simpleButton1.Text = "اضافة عميل";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(28, 118);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(545, 491);
            this.gridControl1.TabIndex = 96;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSuppName,
            this.colSuppAddress,
            this.colSuppPhone,
            this.colSuppMail});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsSelection.CheckBoxSelectorField = "ID";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colSuppName
            // 
            this.colSuppName.FieldName = "SuppName";
            this.colSuppName.MinWidth = 22;
            this.colSuppName.Name = "colSuppName";
            this.colSuppName.Visible = true;
            this.colSuppName.VisibleIndex = 0;
            this.colSuppName.Width = 83;
            // 
            // colSuppAddress
            // 
            this.colSuppAddress.FieldName = "SuppAddress";
            this.colSuppAddress.MinWidth = 22;
            this.colSuppAddress.Name = "colSuppAddress";
            this.colSuppAddress.Visible = true;
            this.colSuppAddress.VisibleIndex = 1;
            this.colSuppAddress.Width = 83;
            // 
            // colSuppPhone
            // 
            this.colSuppPhone.FieldName = "SuppPhone";
            this.colSuppPhone.MinWidth = 22;
            this.colSuppPhone.Name = "colSuppPhone";
            this.colSuppPhone.Visible = true;
            this.colSuppPhone.VisibleIndex = 2;
            this.colSuppPhone.Width = 83;
            // 
            // colSuppMail
            // 
            this.colSuppMail.FieldName = "SuppMail";
            this.colSuppMail.MinWidth = 22;
            this.colSuppMail.Name = "colSuppMail";
            this.colSuppMail.Visible = true;
            this.colSuppMail.VisibleIndex = 3;
            this.colSuppMail.Width = 83;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 78);
            this.panel1.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(411, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "العملاء";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(886, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "البريد";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(602, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 32);
            this.textBox2.TabIndex = 92;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(602, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 32);
            this.textBox1.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(855, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 89;
            this.label8.Text = "رقم الهاتف";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(602, 118);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 32);
            this.txtUsername.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(842, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 87;
            this.label7.Text = "اسم العميل";
            // 
            // Purchasing_Price
            // 
            this.Purchasing_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchasing_Price.Location = new System.Drawing.Point(602, 170);
            this.Purchasing_Price.Name = "Purchasing_Price";
            this.Purchasing_Price.Size = new System.Drawing.Size(235, 32);
            this.Purchasing_Price.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(877, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 85;
            this.label4.Text = "العنوان";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 621);
            this.Controls.Add(this.pnlCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomer";
            this.Text = "FrmUsers";
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Purchasing_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppName;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppMail;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public System.Windows.Forms.Panel pnlCustomer;
    }
}