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
    public partial class MenuFrom : Form
    {
        int foodId = 0;
        public MenuFrom()
        {
            InitializeComponent();
        }

        private void MenuFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuFrom_Load(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            food_ListDataGridView.DataSource = menuService.GetAllFood();
        }

        private void food_ListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodId = (int)food_ListDataGridView.Rows[e.RowIndex].Cells[0].Value;
            foodNameTextBox.Text= food_ListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTextBox.Text= food_ListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            statusTextBox.Text= food_ListDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
