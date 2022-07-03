namespace SalesManagmentSystem2
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCategory = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSuppName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.pnlProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.simpleButton3);
            this.pnlProduct.Controls.Add(this.gridCategory);
            this.pnlProduct.Controls.Add(this.simpleButton2);
            this.pnlProduct.Controls.Add(this.comboBox1);
            this.pnlProduct.Controls.Add(this.label6);
            this.pnlProduct.Controls.Add(this.textBox4);
            this.pnlProduct.Controls.Add(this.label5);
            this.pnlProduct.Controls.Add(this.label4);
            this.pnlProduct.Controls.Add(this.textBox2);
            this.pnlProduct.Controls.Add(this.label3);
            this.pnlProduct.Controls.Add(this.panel1);
            this.pnlProduct.Controls.Add(this.simpleButton1);
            this.pnlProduct.Controls.Add(this.textBox1);
            this.pnlProduct.Controls.Add(this.label1);
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(941, 621);
            this.pnlProduct.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.SystemColors.GrayText;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(674, 337);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(129, 50);
            this.simpleButton2.TabIndex = 39;
            this.simpleButton2.Text = "تعديل ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(545, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 37);
            this.comboBox1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(842, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "الصنف";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(545, 279);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(291, 35);
            this.textBox4.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(842, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(842, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(545, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 35);
            this.textBox2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "سعر المنتج";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 78);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(415, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "المنتجات";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.SystemColors.GrayText;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(809, 337);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(126, 50);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "اضافة منتج";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(545, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 35);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(842, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "اسم المنتج";
            // 
            // gridCategory
            // 
            this.gridCategory.Location = new System.Drawing.Point(5, 84);
            this.gridCategory.MainView = this.gridView1;
            this.gridCategory.Name = "gridCategory";
            this.gridCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCategory.Size = new System.Drawing.Size(520, 433);
            this.gridCategory.TabIndex = 95;
            this.gridCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.gridCategory;
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
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(545, 337);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(123, 50);
            this.simpleButton3.TabIndex = 98;
            this.simpleButton3.Text = "حذف";
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 621);
            this.Controls.Add(this.pnlProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlProduct;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppName;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppMail;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}