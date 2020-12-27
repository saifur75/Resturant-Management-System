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
    public partial class LoginFrom : Form
    {
        ManagerFrom mf;
        WaiterFrom wf;
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void LoginFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            bool result = loginService.Login(userNameTextBox.Text, passwordTextBox.Text);

            if (result)
            {
                if (loginService.GetPost(userNameTextBox.Text).Equals("Manager"))
                {
                    MessageBox.Show("Login Successfully");
                    string post = "Manager";
                    mf = new ManagerFrom(userNameTextBox.Text);
                    mf.Show();
                    this.Hide();
                }
                else if (loginService.GetPost(userNameTextBox.Text).Equals("Waiter"))
                {
                    MessageBox.Show("Login Successfully");
                    wf = new WaiterFrom(userNameTextBox.Text);
                    wf.Show();
                    this.Hide();
                }
            }
            else
            {
                checkLabel.Visible = true;
                return;
            }
        }
    }
}
