namespace SalesManagmentSystem2
{
    partial class Purchasing_invoice
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
            this.inventoryMSDbDataSet8 = new SalesManagmentSystem2.InventoryMSDbDataSet8();
            this.purchasinginvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasing_invoiceTableAdapter = new SalesManagmentSystem2.InventoryMSDbDataSet8TableAdapters.Purchasing_invoiceTableAdapter();
            this.tableAdapterManager = new SalesManagmentSystem2.InventoryMSDbDataSet8TableAdapters.TableAdapterManager();
            this.inventoryMSDbDataSet81 = new SalesManagmentSystem2.InventoryMSDbDataSet8();
            this.purchasing_invoiceTableAdapter1 = new SalesManagmentSystem2.InventoryMSDbDataSet8TableAdapters.Purchasing_invoiceTableAdapter();
            this.purchasing_invoiceGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataProcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasinginvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasing_invoiceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryMSDbDataSet8
            // 
            this.inventoryMSDbDataSet8.DataSetName = "InventoryMSDbDataSet8";
            this.inventoryMSDbDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasinginvoiceBindingSource
            // 
            this.purchasinginvoiceBindingSource.DataMember = "Purchasing_invoice";
            this.purchasinginvoiceBindingSource.DataSource = this.inventoryMSDbDataSet8;
            // 
            // purchasing_invoiceTableAdapter
            // 
            this.purchasing_invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = SalesManagmentSystem2.InventoryMSDbDataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryMSDbDataSet81
            // 
            this.inventoryMSDbDataSet81.DataSetName = "InventoryMSDbDataSet8";
            this.inventoryMSDbDataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasing_invoiceTableAdapter1
            // 
            this.purchasing_invoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // purchasing_invoiceGridControl
            // 
            this.purchasing_invoiceGridControl.DataMember = "Purchasing_invoice";
            this.purchasing_invoiceGridControl.Location = new System.Drawing.Point(8, 173);
            this.purchasing_invoiceGridControl.MainView = this.gridView2;
            this.purchasing_invoiceGridControl.Name = "purchasing_invoiceGridControl";
            this.purchasing_invoiceGridControl.Size = new System.Drawing.Size(1255, 503);
            this.purchasing_invoiceGridControl.TabIndex = 101;
            this.purchasing_invoiceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colFullName,
            this.colExpireDate,
            this.colProductDate,
            this.colDataProcess,
            this.colTotalPrice,
            this.colTotal_quantity,
            this.coltotal});
            this.gridView2.GridControl = this.purchasing_invoiceGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 25;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 94;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 25;
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 94;
            // 
            // colExpireDate
            // 
            this.colExpireDate.FieldName = "ExpireDate";
            this.colExpireDate.MinWidth = 25;
            this.colExpireDate.Name = "colExpireDate";
            this.colExpireDate.Visible = true;
            this.colExpireDate.VisibleIndex = 2;
            this.colExpireDate.Width = 94;
            // 
            // colProductDate
            // 
            this.colProductDate.FieldName = "ProductDate";
            this.colProductDate.MinWidth = 25;
            this.colProductDate.Name = "colProductDate";
            this.colProductDate.Visible = true;
            this.colProductDate.VisibleIndex = 3;
            this.colProductDate.Width = 94;
            // 
            // colDataProcess
            // 
            this.colDataProcess.FieldName = "DataProcess";
            this.colDataProcess.MinWidth = 25;
            this.colDataProcess.Name = "colDataProcess";
            this.colDataProcess.Visible = true;
            this.colDataProcess.VisibleIndex = 4;
            this.colDataProcess.Width = 94;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 25;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 5;
            this.colTotalPrice.Width = 94;
            // 
            // colTotal_quantity
            // 
            this.colTotal_quantity.FieldName = "Total_quantity";
            this.colTotal_quantity.MinWidth = 25;
            this.colTotal_quantity.Name = "colTotal_quantity";
            this.colTotal_quantity.Visible = true;
            this.colTotal_quantity.VisibleIndex = 6;
            this.colTotal_quantity.Width = 94;
            // 
            // coltotal
            // 
            this.coltotal.FieldName = "total";
            this.coltotal.MinWidth = 25;
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 7;
            this.coltotal.Width = 94;
            // 
            // Purchasing_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purchasing_invoiceGridControl);
            this.Name = "Purchasing_invoice";
            this.Text = "Purchasing_invoice";
            this.Load += new System.EventHandler(this.Purchasing_invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasinginvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMSDbDataSet81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasing_invoiceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private InventoryMSDbDataSet8 inventoryMSDbDataSet8;
        private System.Windows.Forms.BindingSource purchasinginvoiceBindingSource;
        private InventoryMSDbDataSet8TableAdapters.Purchasing_invoiceTableAdapter purchasing_invoiceTableAdapter;
        private InventoryMSDbDataSet8TableAdapters.TableAdapterManager tableAdapterManager;
        private InventoryMSDbDataSet8 inventoryMSDbDataSet81;
        private InventoryMSDbDataSet8TableAdapters.Purchasing_invoiceTableAdapter purchasing_invoiceTableAdapter1;
        private DevExpress.XtraGrid.GridControl purchasing_invoiceGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colExpireDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDataProcess;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_quantity;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
    }
}