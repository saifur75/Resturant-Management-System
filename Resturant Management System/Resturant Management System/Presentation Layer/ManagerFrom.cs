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
    }
}
