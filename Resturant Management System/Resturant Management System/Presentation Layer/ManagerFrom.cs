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
        PaymentFrom paymentFrom;
        LoginFrom loginFrom;
        string post;
        string name;
        public ManagerFrom()
        {
            InitializeComponent();
            welcomeLabel.Text += " " + name;
        }
        public ManagerFrom(LoginFrom loginFrom, string name,string post)
        {
            InitializeComponent();
            welcomeLabel.Text += " " + name;
            this.post = post;
            this.loginFrom = loginFrom;

        }
        private void ManagerFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menu = new MenuFrom(this,post);
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewCategory viewCategory  = new ViewCategory(this,post);
            viewCategory.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom =new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void viewOrderButton_Click(object sender, EventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder(this,post);
            viewOrder.Show();
            this.Hide();
        }

        private void billGenerateButton_Click(object sender, EventArgs e)
        {
            paymentFrom = new PaymentFrom(this,post);
            paymentFrom.Show();
            this.Hide();
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            FinancialFrom financialFrom = new FinancialFrom();
            financialFrom.Show();
            this.Hide();
        }
    }
}
