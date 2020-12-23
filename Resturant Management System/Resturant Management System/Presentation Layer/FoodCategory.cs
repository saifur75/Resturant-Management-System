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
    public partial class FoodCategory : Form
    {
        public FoodCategory()
        {
            InitializeComponent();
        }

        private void FoodCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FoodCategory_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            category_Load_DataGridView.DataSource = categoryService.GetAllCategories();
        }
    }
}
