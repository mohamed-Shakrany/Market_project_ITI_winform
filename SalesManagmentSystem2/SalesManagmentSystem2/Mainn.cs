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
        SalesManagmentSystem2.FrmSalesDetails salesDetails = new FrmSalesDetails();
      




        public Mainn()
        {
            
            InitializeComponent();
        }

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

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(home.pnlhome);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmCategories.pnlCat);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmProduct.pnlProduct);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(frmSales.pnlSales);
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(salesDetails.pnlSalesDetails);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            var show = new Frm_Purchases();
            pnlContent.Controls.Add(show.Purchases_details);
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            var show = new FrmPurchasesDetails();
            pnlContent.Controls.Add(show.Purchases_details);
        }
    }
}
