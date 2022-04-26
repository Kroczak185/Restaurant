using System;
using System.Windows.Forms;

namespace Restauracja
{
    public partial class CustomerViewCart : Form
    {
        public Model.Item item;
        public CustomerViewCart(Model.Item a)
        {
            InitializeComponent();
            item = a;
        }

        private void CartItemButtonDecremen_Click(object sender, System.EventArgs e)
        {
            int x = Int32.Parse(CartItemNumberLabel.Text.ToString());
            x--;
            CartItemNumberLabel.Text = x.ToString();
        }

        private void CartItemButtonIncrement_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(CartItemNumberLabel.Text.ToString());
            x++;
            CartItemNumberLabel.Text = x.ToString();
        }
    }
}
