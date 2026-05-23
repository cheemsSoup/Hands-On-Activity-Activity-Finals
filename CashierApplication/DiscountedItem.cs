using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            item_discount = discount * 0.01;
        }

        public override double getTotalPrice()
        {
            double baseTotal = base.getTotalPrice();
            double result = item_discount * baseTotal;
            discounted_price = baseTotal - result;
            return discounted_price;
        }

        public void setPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - getTotalPrice();
        }

        public double getChange()
        {
            return change;
        }
    }
}
