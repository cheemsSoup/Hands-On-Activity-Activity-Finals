using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier("Alijandrei Reyes", "IT Department", "superV_reyes", "123456");

            string uName = txtUsername.Text;
            string uPassword = txtPassword.Text;

            if (cashier.validateLogin(uName, uPassword))
            {
                MessageBox.Show("Welcome, " + cashier.getFullName() + "!\nDepartment: " + cashier.getDepartmet(), "Login Successfuley!");

                frmDiscountedItem mainForm = new frmDiscountedItem();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
