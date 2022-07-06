namespace SalesManagmentSystem2
{
    partial class FrmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchase));
            this.Purchases_Panel = new System.Windows.Forms.Panel();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.show_supplier_data = new DevExpress.XtraGrid.GridControl();
            this.buyProcessesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNationalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataProcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.show_supp_name = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMSDbDataSet4 = new SalesManagmentSystem2.InventoryMSDbDataSet4();
            this.tot_price = new System.Windows.Forms.TextBox();
            this.national_id = new System.Windows.Forms.TextBox();
            this.category_choose = new System.Windows.Forms.ComboBox();
            this.exp_date = new DevExpress.XtraEditors.DateEdit();
            this.pro_date = new DevExpress.XtraEditors.DateEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridControl_buy_process_pro = new DevExpress.XtraGrid.GridControl();
            this.buyProcessProductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMSDbDataSet7 = new SalesManagmentSystem2.InventoryMSDbDataSet7();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_p = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_bp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.op_date = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add_new = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rep_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.inventoryMSDbDataSet6 = new SalesManagmentSystem2.InventoryMSDbDataSet6();
            this.buyProcessProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyProcessProductsTableAdapter = new SalesManagmentSystem2.InventoryMSDbDataSet6TableAdapters.BuyProcessProductsTableAdapter();
            this.buyProcessProductsTableAdapter1 = new SalesManagmentSystem2.InventoryMSDbDataSet7TableAdapters.BuyProcessProductsTableAdapter();
            this.tableAdapterManager = new SalesManagmentSystem2.InventoryMSDbDataSet4TableAdapters.TableAdapterManager();
            this.productsTableAdapter = new SalesManagmentSystem2.InventoryMSDbDataSet4TableAdapters.ProductsTableAdapter();
            this.Purchases_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_supplier_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyProcessesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_buy_process_pro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyProcessProductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_date.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyProcessProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Purchases_Panel
            // 
            this.Purchases_Panel.Controls.Add(this.simpleButton7);
            this.Purchases_Panel.Controls.Add(this.simpleButton6);
            this.Purchases_Panel.Controls.Add(this.show_supplier_data);
            this.Purchases_Panel.Controls.Add(this.show_supp_name);
            this.Purchases_Panel.Controls.Add(this.tot_price);
            this.Purchases_Panel.Controls.Add(this.national_id);
            this.Purchases_Panel.Controls.Add(this.category_choose);
            this.Purchases_Panel.Controls.Add(this.exp_date);
            this.Purchases_Panel.Controls.Add(this.pro_date);
            this.Purchases_Panel.Controls.Add(this.comboBox1);
            this.Purchases_Panel.Controls.Add(this.gridControl_buy_process_pro);
            this.Purchases_Panel.Controls.Add(this.label13);
            this.Purchases_Panel.Controls.Add(this.label12);
            this.Purchases_Panel.Controls.Add(this.label11);
            this.Purchases_Panel.Controls.Add(this.label6);
            this.Purchases_Panel.Controls.Add(this.quantity);
            this.Purchases_Panel.Controls.Add(this.label5);
            this.Purchases_Panel.Controls.Add(this.simpleButton4);
            this.Purchases_Panel.Controls.Add(this.label10);
            this.Purchases_Panel.Controls.Add(this.label9);
            this.Purchases_Panel.Controls.Add(this.op_date);
            this.Purchases_Panel.Controls.Add(this.simpleButton3);
            this.Purchases_Panel.Controls.Add(this.label7);
            this.Purchases_Panel.Controls.Add(this.btnEdit);
            this.Purchases_Panel.Controls.Add(this.btn_add_new);
            this.Purchases_Panel.Controls.Add(this.label3);
            this.Purchases_Panel.Controls.Add(this.rep_name);
            this.Purchases_Panel.Controls.Add(this.label1);
            this.Purchases_Panel.Controls.Add(this.panel1);
            this.Purchases_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Purchases_Panel.Location = new System.Drawing.Point(0, 0);
            this.Purchases_Panel.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.Purchases_Panel.MaximumSize = new System.Drawing.Size(2500, 2500);
            this.Purchases_Panel.MinimumSize = new System.Drawing.Size(2500, 2500);
            this.Purchases_Panel.Name = "Purchases_Panel";
            this.Purchases_Panel.Size = new System.Drawing.Size(2500, 2500);
            this.Purchases_Panel.TabIndex = 0;
            this.Purchases_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Purchases_Panel_Paint);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(952, 744);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(66, 56);
            this.simpleButton7.TabIndex = 112;
            this.simpleButton7.Text = "PDF";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(12, 744);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(66, 56);
            this.simpleButton6.TabIndex = 111;
            this.simpleButton6.Text = " PDF";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // show_supplier_data
            // 
            this.show_supplier_data.DataSource = this.buyProcessesBindingSource;
            this.show_supplier_data.Location = new System.Drawing.Point(-12, 311);
            this.show_supplier_data.MainView = this.gridView1;
            this.show_supplier_data.Name = "show_supplier_data";
            this.show_supplier_data.Size = new System.Drawing.Size(682, 427);
            this.show_supplier_data.TabIndex = 106;
            this.show_supplier_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.show_supplier_data.Click += new System.EventHandler(this.show_supplier_data_Click);
            // 
            // buyProcessesBindingSource
            // 
            this.buyProcessesBindingSource.DataSource = typeof(SalesManagmentSystem2.DAL.Models.BuyProcess);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFullName,
            this.colNationalID,
            this.colTotalPrice,
            this.colDataProcess,
            this.colSupplierId});
            this.gridView1.GridControl = this.show_supplier_data;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 25;
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.OptionsColumn.AllowFocus = false;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 94;
            // 
            // colNationalID
            // 
            this.colNationalID.FieldName = "NationalID";
            this.colNationalID.MinWidth = 25;
            this.colNationalID.Name = "colNationalID";
            this.colNationalID.OptionsColumn.AllowEdit = false;
            this.colNationalID.OptionsColumn.AllowFocus = false;
            this.colNationalID.Visible = true;
            this.colNationalID.VisibleIndex = 2;
            this.colNationalID.Width = 94;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 25;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowEdit = false;
            this.colTotalPrice.OptionsColumn.AllowFocus = false;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 3;
            this.colTotalPrice.Width = 94;
            // 
            // colDataProcess
            // 
            this.colDataProcess.FieldName = "DataProcess";
            this.colDataProcess.MinWidth = 25;
            this.colDataProcess.Name = "colDataProcess";
            this.colDataProcess.OptionsColumn.AllowEdit = false;
            this.colDataProcess.OptionsColumn.AllowFocus = false;
            this.colDataProcess.Visible = true;
            this.colDataProcess.VisibleIndex = 4;
            this.colDataProcess.Width = 94;
            // 
            // colSupplierId
            // 
            this.colSupplierId.FieldName = "SupplierId";
            this.colSupplierId.MinWidth = 25;
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.OptionsColumn.AllowEdit = false;
            this.colSupplierId.OptionsColumn.AllowFocus = false;
            this.colSupplierId.Visible = true;
            this.colSupplierId.VisibleIndex = 5;
            this.colSupplierId.Width = 94;
            // 
            // show_supp_name
            // 
            this.show_supp_name.DataSource = this.productsBindingSource;
            this.show_supp_name.DisplayMember = "ProductName";
            this.show_supp_name.FormattingEnabled = true;
            this.show_supp_name.Location = new System.Drawing.Point(774, 82);
            this.show_supp_name.Name = "show_supp_name";
            this.show_supp_name.Size = new System.Drawing.Size(347, 24);
            this.show_supp_name.TabIndex = 105;
            this.show_supp_name.ValueMember = "ProductID";
            this.show_supp_name.SelectionChangeCommitted += new System.EventHandler(this.show_supp_name_SelectionChangeCommitted);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.inventoryMSDbDataSet4;
            // 
            // inventoryMSDbDataSet4
            // 
            this.inventoryMSDbDataSet4.DataSetName = "InventoryMSDbDataSet4";
            this.inventoryMSDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tot_price
            // 
            this.tot_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_price.Location = new System.Drawing.Point(123, 172);
            this.tot_price.Margin = new System.Windows.Forms.Padding(4);
            this.tot_price.Name = "tot_price";
            this.tot_price.Size = new System.Drawing.Size(347, 34);
            this.tot_price.TabIndex = 104;
            this.tot_price.Leave += new System.EventHandler(this.tot_price_Leave);
            // 
            // national_id
            // 
            this.national_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.national_id.Location = new System.Drawing.Point(123, 125);
            this.national_id.Margin = new System.Windows.Forms.Padding(4);
            this.national_id.Name = "national_id";
            this.national_id.Size = new System.Drawing.Size(345, 34);
            this.national_id.TabIndex = 103;
            this.national_id.Leave += new System.EventHandler(this.national_id_Leave);
            // 
            // category_choose
            // 
            this.category_choose.DataSource = this.productsBindingSource;
            this.category_choose.DisplayMember = "ProductName";
            this.category_choose.FormattingEnabled = true;
            this.category_choose.Location = new System.Drawing.Point(774, 123);
            this.category_choose.Name = "category_choose";
            this.category_choose.Size = new System.Drawing.Size(347, 24);
            this.category_choose.TabIndex = 101;
            this.category_choose.ValueMember = "ProductID";
            // 
            // exp_date
            // 
            this.exp_date.EditValue = null;
            this.exp_date.Location = new System.Drawing.Point(774, 267);
            this.exp_date.Margin = new System.Windows.Forms.Padding(4);
            this.exp_date.Name = "exp_date";
            this.exp_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.exp_date.Properties.Appearance.Options.UseFont = true;
            this.exp_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exp_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.exp_date.Size = new System.Drawing.Size(348, 34);
            this.exp_date.TabIndex = 100;
            this.exp_date.EditValueChanged += new System.EventHandler(this.exp_date_EditValueChanged);
            this.exp_date.Leave += new System.EventHandler(this.exp_date_Leave);
            // 
            // pro_date
            // 
            this.pro_date.EditValue = null;
            this.pro_date.Location = new System.Drawing.Point(772, 215);
            this.pro_date.Margin = new System.Windows.Forms.Padding(4);
            this.pro_date.Name = "pro_date";
            this.pro_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.pro_date.Properties.Appearance.Options.UseFont = true;
            this.pro_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pro_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pro_date.Size = new System.Drawing.Size(348, 34);
            this.pro_date.TabIndex = 99;
            this.pro_date.EditValueChanged += new System.EventHandler(this.pro_date_EditValueChanged);
            this.pro_date.Leave += new System.EventHandler(this.pro_date_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productsBindingSource;
            this.comboBox1.DisplayMember = "ProductName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 24);
            this.comboBox1.TabIndex = 98;
            this.comboBox1.ValueMember = "ProductID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // gridControl_buy_process_pro
            // 
            this.gridControl_buy_process_pro.DataSource = this.buyProcessProductsBindingSource1;
            this.gridControl_buy_process_pro.Location = new System.Drawing.Point(686, 311);
            this.gridControl_buy_process_pro.MainView = this.gridView2;
            this.gridControl_buy_process_pro.Name = "gridControl_buy_process_pro";
            this.gridControl_buy_process_pro.Size = new System.Drawing.Size(561, 427);
            this.gridControl_buy_process_pro.TabIndex = 96;
            this.gridControl_buy_process_pro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // buyProcessProductsBindingSource1
            // 
            this.buyProcessProductsBindingSource1.DataMember = "BuyProcessProducts";
            this.buyProcessProductsBindingSource1.DataSource = this.inventoryMSDbDataSet7;
            // 
            // inventoryMSDbDataSet7
            // 
            this.inventoryMSDbDataSet7.DataSetName = "InventoryMSDbDataSet7";
            this.inventoryMSDbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_p,
            this.colId_bp,
            this.colTotal_quantity,
            this.colProductDate,
            this.colExpireDate});
            this.gridView2.GridControl = this.gridControl_buy_process_pro;
            this.gridView2.Name = "gridView2";
            // 
            // colId_p
            // 
            this.colId_p.FieldName = "Id_p";
            this.colId_p.MinWidth = 25;
            this.colId_p.Name = "colId_p";
            this.colId_p.OptionsColumn.AllowEdit = false;
            this.colId_p.OptionsColumn.AllowFocus = false;
            this.colId_p.Visible = true;
            this.colId_p.VisibleIndex = 0;
            this.colId_p.Width = 94;
            // 
            // colId_bp
            // 
            this.colId_bp.FieldName = "Id_bp";
            this.colId_bp.MinWidth = 25;
            this.colId_bp.Name = "colId_bp";
            this.colId_bp.OptionsColumn.AllowEdit = false;
            this.colId_bp.OptionsColumn.AllowFocus = false;
            this.colId_bp.Visible = true;
            this.colId_bp.VisibleIndex = 1;
            this.colId_bp.Width = 94;
            // 
            // colTotal_quantity
            // 
            this.colTotal_quantity.FieldName = "Total_quantity";
            this.colTotal_quantity.MinWidth = 25;
            this.colTotal_quantity.Name = "colTotal_quantity";
            this.colTotal_quantity.OptionsColumn.AllowEdit = false;
            this.colTotal_quantity.OptionsColumn.AllowFocus = false;
            this.colTotal_quantity.Visible = true;
            this.colTotal_quantity.VisibleIndex = 2;
            this.colTotal_quantity.Width = 94;
            // 
            // colProductDate
            // 
            this.colProductDate.FieldName = "ProductDate";
            this.colProductDate.MinWidth = 25;
            this.colProductDate.Name = "colProductDate";
            this.colProductDate.OptionsColumn.AllowEdit = false;
            this.colProductDate.OptionsColumn.AllowFocus = false;
            this.colProductDate.Visible = true;
            this.colProductDate.VisibleIndex = 3;
            this.colProductDate.Width = 94;
            // 
            // colExpireDate
            // 
            this.colExpireDate.FieldName = "ExpireDate";
            this.colExpireDate.MinWidth = 25;
            this.colExpireDate.Name = "colExpireDate";
            this.colExpireDate.OptionsColumn.AllowEdit = false;
            this.colExpireDate.OptionsColumn.AllowFocus = false;
            this.colExpireDate.Visible = true;
            this.colExpireDate.VisibleIndex = 4;
            this.colExpireDate.Width = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(506, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 29);
            this.label13.TabIndex = 90;
            this.label13.Text = "رقم البطاقة";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(545, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 29);
            this.label12.TabIndex = 90;
            this.label12.Text = "السعر";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1130, 270);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 29);
            this.label11.TabIndex = 90;
            this.label11.Text = "تاريخ الانتهاء";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1136, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 29);
            this.label6.TabIndex = 88;
            this.label6.Text = "تاريخ الانتاج";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(772, 170);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(347, 34);
            this.quantity.TabIndex = 87;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            this.quantity.Leave += new System.EventHandler(this.quantity_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1191, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 86;
            this.label5.Text = "الكمية";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.SystemColors.GrayText;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(-397, -125);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(128, 46);
            this.simpleButton4.TabIndex = 84;
            this.simpleButton4.Text = "اضافة";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(535, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 29);
            this.label10.TabIndex = 82;
            this.label10.Text = "المنتج";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1167, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 80;
            this.label9.Text = "  الصنف";
            // 
            // op_date
            // 
            this.op_date.EditValue = null;
            this.op_date.Location = new System.Drawing.Point(123, 269);
            this.op_date.Margin = new System.Windows.Forms.Padding(4);
            this.op_date.Name = "op_date";
            this.op_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.op_date.Properties.Appearance.Options.UseFont = true;
            this.op_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.op_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.op_date.Size = new System.Drawing.Size(348, 34);
            this.op_date.TabIndex = 77;
            this.op_date.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            this.op_date.Layout += new System.Windows.Forms.LayoutEventHandler(this.op_date_Layout);
            this.op_date.Leave += new System.EventHandler(this.op_date_Leave);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(91, 745);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(168, 55);
            this.simpleButton3.TabIndex = 73;
            this.simpleButton3.Text = "حذف ";
            this.simpleButton3.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 76;
            this.label7.Text = "التاريخ";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(267, 745);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 55);
            this.btnEdit.TabIndex = 72;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btn_add_new
            // 
            this.btn_add_new.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_add_new.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btn_add_new.Appearance.Options.UseBackColor = true;
            this.btn_add_new.Appearance.Options.UseFont = true;
            this.btn_add_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_new.ImageOptions.Image")));
            this.btn_add_new.Location = new System.Drawing.Point(463, 745);
            this.btn_add_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(168, 55);
            this.btn_add_new.TabIndex = 71;
            this.btn_add_new.Text = "اضافة شراء";
            this.btn_add_new.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1153, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 53;
            this.label3.Text = "اسم المورد";
            // 
            // rep_name
            // 
            this.rep_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rep_name.Location = new System.Drawing.Point(121, 82);
            this.rep_name.Margin = new System.Windows.Forms.Padding(4);
            this.rep_name.Name = "rep_name";
            this.rep_name.Size = new System.Drawing.Size(347, 34);
            this.rep_name.TabIndex = 51;
            this.rep_name.TextChanged += new System.EventHandler(this.rep_name_TextChanged);
            this.rep_name.Leave += new System.EventHandler(this.rep_name_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "اسم المندوب";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2500, 74);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(553, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "تفاصل المشتريات";
            // 
            // inventoryMSDbDataSet6
            // 
            this.inventoryMSDbDataSet6.DataSetName = "InventoryMSDbDataSet6";
            this.inventoryMSDbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyProcessProductsBindingSource
            // 
            this.buyProcessProductsBindingSource.DataMember = "BuyProcessProducts";
            this.buyProcessProductsBindingSource.DataSource = this.inventoryMSDbDataSet6;
            // 
            // buyProcessProductsTableAdapter
            // 
            this.buyProcessProductsTableAdapter.ClearBeforeFill = true;
            // 
            // buyProcessProductsTableAdapter1
            // 
            this.buyProcessProductsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SalesManagmentSystem2.InventoryMSDbDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 820);
            this.Controls.Add(this.Purchases_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPurchase";
            this.Text = "FrmSalesDetails";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            this.Purchases_Panel.ResumeLayout(false);
            this.Purchases_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_supplier_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyProcessesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_buy_process_pro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyProcessProductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_date.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyProcessProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Purchases_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rep_name;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.DateEdit op_date;
        private System.Windows.Forms.Label label7;
        private InventoryMSDbDataSet6 inventoryMSDbDataSet6;
        private System.Windows.Forms.BindingSource buyProcessProductsBindingSource;
        private InventoryMSDbDataSet6TableAdapters.BuyProcessProductsTableAdapter buyProcessProductsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl_buy_process_pro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private InventoryMSDbDataSet7 inventoryMSDbDataSet7;
        private System.Windows.Forms.BindingSource buyProcessProductsBindingSource1;
        private InventoryMSDbDataSet7TableAdapters.BuyProcessProductsTableAdapter buyProcessProductsTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colId_p;
        private DevExpress.XtraGrid.Columns.GridColumn colId_bp;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_quantity;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExpireDate;
        private InventoryMSDbDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private InventoryMSDbDataSet4 inventoryMSDbDataSet4;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private InventoryMSDbDataSet4TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox national_id;
        private System.Windows.Forms.TextBox tot_price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraGrid.GridControl show_supplier_data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox show_supp_name;
        private System.Windows.Forms.ComboBox category_choose;
        private DevExpress.XtraEditors.DateEdit exp_date;
        private DevExpress.XtraEditors.DateEdit pro_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_add_new;
        private System.Windows.Forms.BindingSource buyProcessesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colNationalID;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDataProcess;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierId;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
    }
}