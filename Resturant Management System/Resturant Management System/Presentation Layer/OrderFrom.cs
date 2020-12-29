﻿using Resturant_Management_System.Resturant_Logic_Layer;
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
        string post;
        public OrderFrom()
        {
            InitializeComponent();
        }

        private void OrderFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void menu_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            food_Name_TextBox.Text = menu_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTextBox.Text = menu_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (quantity_TextBox.Text != "")
            {
                int text = (Convert.ToInt32(priceTextBox.Text)) * (Convert.ToInt32(quantity_TextBox.Text));
                total_Price_TextBox.Text = text.ToString();
            }
            else
            {
                MessageBox.Show("Give the quantity");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (food_Name_TextBox.Text == "" || priceTextBox.Text == "" || quantity_TextBox.Text == "" || dateTimePicker1.Text == "" || total_Price_TextBox.Text == "")
            {
                MessageBox.Show("Fill up the required from");
            }
            else
            {
                OrderService orderService = new OrderService();
                int result = orderService.AddOrder(food_Name_TextBox.Text, quantity_TextBox.Text, total_Price_TextBox.Text, dateTimePicker1.Text);
                if (result > 0)
                {
                    MessageBox.Show("Order added seccessfully");
                    this.Refresh(this, null);
                    this.ClearMenu(this, null);
                }
                else
                {
                    MessageBox.Show("Order can`t add");
                }
            }
        }
        void Refresh(object sender, EventArgs e)
        {
            MenuService menuService = new MenuService();
            menu_DataGridView.DataSource = menuService.GetAllFood();
            OrderService orderService = new OrderService();
            order_DataGridView.DataSource = orderService.GetAllOrder();
        }
        void ClearMenu(object sender, EventArgs e)
        {
            food_Name_TextBox.Text = priceTextBox.Text = quantity_TextBox.Text = total_Price_TextBox.Text = string.Empty;
        }
        void ClearOrder(object sender, EventArgs e)
        {
            foodNameTextBox2.Text = total_Amount_TextBox.Text = string.Empty;
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();
            loginFrom.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
