using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesManagmentSystem2.DAL.DbInventory;
using SalesManagmentSystem2.DAL.Models;
using SalesManagmentSystem2.PL;

namespace SalesManagmentSystem2
{
    public partial class FrmUser : Form
    {
        InventoryDB db = new InventoryDB();
        public FrmUser()
        {
            InitializeComponent();
            griduser.DataSource = db.Users.Local.ToBindingList();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMSDbDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.inventoryMSDbDataSet.Users);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
