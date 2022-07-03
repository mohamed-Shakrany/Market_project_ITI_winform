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
    public partial class FrmSales : Form
    {
        public Panel Purchases_details
        {
            get
            {
                return Purchase_detaisl_Panel;
            }
        }

        //SalesManagmentSystem2.FrmSales frmSales2 = new FrmSales();
        //SalesManagmentSystem2.FrmHome frmHome = new FrmHome();
        public FrmSales()
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


        }
        bool check_quantity = false;
        bool Check_Price = false;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchasing_Price_TextChanged(object sender, EventArgs e)
        {
        //    if (System.Text.RegularExpressions.Regex.IsMatch(Purchasing_Price.Text, "[^0-9]")
        //)
        //    {
        //        MessageBox.Show("Please enter only numbers.");
        //        Purchasing_Price.Text = Purchasing_Price.Text.Remove(Purchasing_Price.Text.Length - 1);
        //    }
        //    else
        //        Check_Price = true;
        //    if (check_quantity && Check_Price && !String.IsNullOrEmpty(Quantity_Purchased.Text) && !String.IsNullOrEmpty(Purchasing_Price.Text))
        //    {
        //        //  var m = int.Parse(quantity_check.Text) * int.Parse(price_check.Text);
        //        Total_Item_Purchased.Text = (int.Parse(Quantity_Purchased.Text) * int.Parse(Purchasing_Price.Text)).ToString();

        //    }
        //    else
        //    {
        //        Total_Item_Purchased.Text = "-";
        //    }
        }

        private void Quantity_Purchased_Leave(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(Quantity_Purchased.Text, "[^0-9]")
            //  )
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    Quantity_Purchased.Text = Quantity_Purchased.Text.Remove(Quantity_Purchased.Text.Length - 1);
            //}
            //else
            //{
            //    check_quantity = true;

            //} if (check_quantity && Check_Price && !String.IsNullOrEmpty(Quantity_Purchased.Text) && !String.IsNullOrEmpty(Purchasing_Price.Text))
            //{
            //    //  var m = int.Parse(quantity_check.Text) * int.Parse(price_check.Text);
            //    Total_Item_Purchased.Text = (int.Parse(Quantity_Purchased.Text) * int.Parse(Purchasing_Price.Text)).ToString();

            //}
            //else
            //{
            //    Total_Item_Purchased.Text ="-";
            //}


        }
        public void ch(Label l)
        {
            //Total_Item_Purchased = l;
            ////while (check_quantity && Check_Price && !String.IsNullOrEmpty(Quantity_Purchased.Text) && !String.IsNullOrEmpty(Purchasing_Price.Text))
            ////{
            ////    //  var m = int.Parse(quantity_check.Text) * int.Parse(price_check.Text);
            ////    Total_Item_Purchased.Text = (int.Parse(Quantity_Purchased.Text) * int.Parse(Purchasing_Price.Text)).ToString();

            ////}
        }

    }
}
