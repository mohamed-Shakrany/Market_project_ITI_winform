using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagmentSystem2
{
    
    public partial class Mainn : Form
    {
        SalesManagmentSystem2.FrmHome home = new FrmHome();
        SalesManagmentSystem2.FrmCategories frmCategories = new FrmCategories();
        SalesManagmentSystem2.FrmProduct frmProduct = new FrmProduct();
        SalesManagmentSystem2.FrmSales frmSales = new FrmSales();
        SalesManagmentSystem2.FrmPurchase frmPurchase = new FrmPurchase();
        SalesManagmentSystem2.PL.FrmCustomer frmCustomer = new PL.FrmCustomer();
        SalesManagmentSystem2.FrmUser frmUser=new FrmUser();
        SalesManagmentSystem2.PL.Frm_Supplier frm_Supplier = new PL.Frm_Supplier();
        SalesManagmentSystem2.PL.MessageDialog messageDialog = new PL.MessageDialog();




        public Mainn()
        {
            
            InitializeComponent();
        }


        //btnCollapse
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (pnlright.Width == 243)
            {
                pnlcollapse.Location = new Point(2, 5);
                pnlright.Width = 50;
                pnlnavTitle.Visible = false;
                pnlnav.Height = 150;

            }
            else
            {
                pnlcollapse.Location = new Point(202, 5);
                pnlright.Width = 243;
                pnlnavTitle.Visible = true;
                pnlnav.Height = 169;
            }
        }

        //btnExit
        private void btnclose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //btnMax
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        //btnMin
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }


        //btnHome
        //btnHome
        private void btnCat_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(home.pnlhome);
        }

        //btnCategory
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmCategories.pnlCat);
        }

        //btnProduct
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmProduct.pnlProduct);
        }

        //btnSales
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            var show = new FrmSales();
            pnlContent.Controls.Add(show.Purchases_details);
        }

        //btnSalesDetails
        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            //pnlContent.Controls.Clear();
            //pnlContent.Controls.Add(salesDetails.pnlSalesDetails);
        }
        //btnPurchase
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            var show = new FrmPurchase();
            pnlContent.Controls.Add(show.pnlSalesDetails);
        }

        //btnPurchaseDetails
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
           
        }

        //btnSupplier
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(frm_Supplier.Page_supplier);
        }

        //btnUsers
        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(frmUser.pnlUser);
        }

        //btnCustomers
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmCategories.pnlCat);

        }
    }
}
