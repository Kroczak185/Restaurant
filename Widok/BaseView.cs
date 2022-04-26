using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restauracja.Widok
{
    public partial class BaseView : Form
    {
        public BaseView()
        {
            InitializeComponent();

        }

        private void basePictoreboxCustomer_MouseLeave(object sender, EventArgs e)
        {
            basePanelCustomer.BackColor = Color.White;
        }

        private void basePictoreboxCustomer_MouseEnter(object sender, EventArgs e)
        {
            basePanelCustomer.BackColor = Color.LightGray;
        }

        private void basePictureboxWaiter_MouseEnter(object sender, EventArgs e)
        {
            basePanelWaiter.BackColor = Color.LightGray;
        }

        private void basePictureboxWaiter_MouseLeave(object sender, EventArgs e)
        {
            basePanelWaiter.BackColor = Color.White;
        }

        private void basePictureboxChef_MouseEnter(object sender, EventArgs e)
        {
            basePanelChef.BackColor = Color.LightGray;
        }

        private void basePictureboxChef_MouseLeave(object sender, EventArgs e)
        {
            basePanelChef.BackColor = Color.White;
        }

        private void basePictoreboxCustomer_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            Controls.Clear();
            Controls.Add(customerView);
            customerView.Show();
        }

        private void basePictureboxWaiter_Click(object sender, EventArgs e)
        {
            WaiterView waiterView = new WaiterView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            Controls.Clear();
            Controls.Add(waiterView);
            waiterView.Show();
        }

        private void basePictureboxChef_Click(object sender, EventArgs e)
        {
            ChefView chefView = new ChefView() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            Controls.Clear();
            Controls.Add(chefView);
            chefView.Show();
        }
    }
}
