using Resturant_Management_System.Resturant_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System.Presentation_Layer
{
    public partial class OrderFrom : Form
    {
        public OrderFrom()
        {
            InitializeComponent();
        }

        private void OrderFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void OrderFrom_Load(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            menu_DataGridView.DataSource = menuService.GetAllFood();
            OrderService orderService = new OrderService();
            order_DataGridView.DataSource = orderService.GetAllOrder();
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            menu_DataGridView.DataSource = menuService.GetProductListForSearch(searchTextBox.Text);
        }
    }
}
