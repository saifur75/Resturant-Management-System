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
    public partial class WaiterFrom : Form
    {
        MenuFrom menu;
        OrderFrom orderFrom;
        LoginFrom loginFrom;
        string post;
        public WaiterFrom()
        {
            InitializeComponent();
        }
        public WaiterFrom(LoginFrom loginFrom, string name,string post)
        {
            InitializeComponent();
            welcomeLabel.Text += " " + name;
            this.loginFrom = loginFrom;
            this.post = post;

        }
        private void WaiterFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            menu = new MenuFrom(this,post);
            menu.Show();
            this.Hide();
        }

        private void takeOrderButton_Click(object sender, EventArgs e)
        { 
            orderFrom = new OrderFrom(this,post);
            orderFrom.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewCategory viewCategory = new ViewCategory(this,post);
            viewCategory.Show();
            this.Hide();
        }
    }
}
