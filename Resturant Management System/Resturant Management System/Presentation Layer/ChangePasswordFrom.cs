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
    public partial class ChangePasswordFrom : Form
    {
        public ChangePasswordFrom()
        {
            InitializeComponent();
        }

        private void ChangePasswordFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
