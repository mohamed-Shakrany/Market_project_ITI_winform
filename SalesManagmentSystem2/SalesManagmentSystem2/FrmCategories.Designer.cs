namespace SalesManagmentSystem2
{
    partial class FrmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            this.pnlCat = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCategory = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSuppName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.pnlCat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCat
            // 
            this.pnlCat.Controls.Add(this.btnDelete);
            this.pnlCat.Controls.Add(this.btnEdit);
            this.pnlCat.Controls.Add(this.btnAdd);
            this.pnlCat.Controls.Add(this.gridCategory);
            this.pnlCat.Controls.Add(this.panel1);
            this.pnlCat.Controls.Add(this.textBox1);
            this.pnlCat.Controls.Add(this.label1);
            this.pnlCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCat.Location = new System.Drawing.Point(0, 0);
            this.pnlCat.Name = "pnlCat";
            this.pnlCat.Size = new System.Drawing.Size(941, 621);
            this.pnlCat.TabIndex = 0;
            this.pnlCat.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCat_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 78);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(415, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاصناف";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(542, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 35);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم الصنف";
            // 
            // gridCategory
            // 
            this.gridCategory.Location = new System.Drawing.Point(0, 126);
            this.gridCategory.MainView = this.gridView1;
            this.gridCategory.Name = "gridCategory";
            this.gridCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCategory.Size = new System.Drawing.Size(528, 433);
            this.gridCategory.TabIndex = 94;
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
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(542, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 45);
            this.btnDelete.TabIndex = 97;
            this.btnDelete.Text = "حذف";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(671, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 45);
            this.btnEdit.TabIndex = 96;
            this.btnEdit.Text = "تعديل";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(806, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 45);
            this.btnAdd.TabIndex = 95;
            this.btnAdd.Text = "اضافة صنف";
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 621);
            this.Controls.Add(this.pnlCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategories";
            this.Text = "FrmCategories";
            this.pnlCat.ResumeLayout(false);
            this.pnlCat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private DevExpress.XtraGrid.GridControl gridCategory;
        //private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlCat;
        private DevExpress.XtraGrid.GridControl gridCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppName;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppMail;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        //private DevExpress.XtraEditors.SimpleButton simpleButton3;
        //private DevExpress.XtraEditors.SimpleButton simpleButton2;
        //private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}