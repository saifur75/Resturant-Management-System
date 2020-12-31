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
    public partial class AdminFrom : Form
    {
        AddEmployee addEmployee;
        LoginFrom loginFrom;
        string name;
        string post;
        public AdminFrom(LoginFrom loginFrom, string name,string post)
        {
            InitializeComponent();
            welcomelabel.Text +=" " +name;
            this.post = post;
            this.loginFrom = loginFrom;
        }

        private void AdminFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployee = new AddEmployee(this);
            addEmployee.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {           
            MenuFrom menuFrom = new MenuFrom(this,post);
            menuFrom.Show();
            this.Hide();
        }

        private void btnFinancials_Click(object sender, EventArgs e)
        {          
            FinancialFrom financialFrom = new FinancialFrom(this,post);
            financialFrom.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {            
            OrderFrom orderFrom = new OrderFrom(this,post);
            orderFrom.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {           
            PaymentFrom paymentFrom =new PaymentFrom(this,post);
            paymentFrom.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();

        }

        private void food_Category_Button_Click(object sender, EventArgs e)
        {
            FoodCategory foodCategory = new FoodCategory(this);
            foodCategory.Show();
            this.Hide();
        }
    }
}
