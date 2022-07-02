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
    public partial class FrmSalesDetails : Form
    {

        //SalesManagmentSystem2.FrmSales frmSales2 = new FrmSales();
        //SalesManagmentSystem2.FrmHome frmHome = new FrmHome();
        public FrmSalesDetails()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void pnlSalesDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndisplaydetails_Click(object sender, EventArgs e)
        {
            //pnlSalesDetails.Controls.Clear();
            //pnlSalesDetails.Controls.Add(frmSales2.pnlSales);
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {

            //pnlSalesDetails.Controls.Clear();
            //pnlSalesDetails.Controls.Add(frmHome.pnlhome);
        }
    }
}
