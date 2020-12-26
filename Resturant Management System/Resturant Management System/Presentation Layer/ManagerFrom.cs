using Resturant_Management_System.Entities;
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
    public partial class ManagerFrom : Form
    {
        MenuFrom menu;
        FoodCategory foodCategory;
        public ManagerFrom()
        {
            InitializeComponent();
        }
        public ManagerFrom(string name)
        {
            InitializeComponent();
            welcomeLabel.Text +=" "+name;
        }
        private void ManagerFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //menu = new MenuFrom(this);
            //menu.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foodCategory = new FoodCategory();
            foodCategory.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom =new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }
    }
}
