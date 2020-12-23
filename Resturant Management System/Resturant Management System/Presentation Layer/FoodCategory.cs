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
        int id = 0;
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
            if(categoryName_TextBox.Text == "")
            {
                MessageBox.Show("Fill up the required From");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.AddCategory(categoryName_TextBox.Text);
                if(result>0)
                {
                    MessageBox.Show("Added successfully");
                }
                else
                {
                    MessageBox.Show("Error occur!");
                }
            }
           
        }

        private void FoodCategory_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            category_Load_DataGridView.DataSource = categoryService.GetAllCategories();
        }

        private void update_Category_Button_Click(object sender, EventArgs e)
        {
            if (categoryName_TextBox.Text == "")
            {
                MessageBox.Show("Fill up the required From");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.UpdateCategory(id,categoryName_TextBox.Text);
                if (result > 0)
                {
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    MessageBox.Show("Error occur!");
                }
            }
        }

        private void category_Load_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =(int) category_Load_DataGridView.Rows[e.RowIndex].Cells[0].Value;
            categoryName_TextBox.Text= category_Load_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void delete_Category_Button_Click(object sender, EventArgs e)
        {
            if (categoryName_TextBox.Text == "")
            {
                MessageBox.Show("Fill up the required From");
            }
            else
            {
                CategoryService categoryService = new CategoryService();
                int result = categoryService.DeleteCategory(id);
                if (result > 0)
                {
                    MessageBox.Show("Delete successfully");
                }
                else
                {
                    MessageBox.Show("Error occur!");
                }
            }
        }
    }
}
