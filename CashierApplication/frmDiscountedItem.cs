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
    public partial class frmDiscountedItem : Form
    {
        public frmDiscountedItem()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string name = txtItem.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            DiscountedItem item = new DiscountedItem(name, price, quantity, discount);

            double total = item.getTotalPrice();
            lblTotalAmount.Text = total.ToString("F2") + "  Php";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtItem.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);
            double payment = Convert.ToDouble(txtPayment.Text);

            DiscountedItem item = new DiscountedItem(name, price, quantity, discount);
            item.setPayment(payment);

            lblChange.Text = item.getChange().ToString("F2") + "  Php";
        }
    }
}
