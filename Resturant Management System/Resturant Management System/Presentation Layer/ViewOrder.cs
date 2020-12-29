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
    public partial class ViewOrder : Form
    {
        ManagerFrom mf;
        string post;
        public ViewOrder(ManagerFrom mf,string post)
        {
            InitializeComponent();
            this.mf = mf;
            this.post = post;
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            order_DataGridView.DataSource = orderService.GetAllOrder();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (post.Equals("Admin"))
            {
                //mf.Show();
                //this.Hide();
            }
            else
            {
                mf.Show();
                this.Hide();
            }
        }

        private void ViewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
