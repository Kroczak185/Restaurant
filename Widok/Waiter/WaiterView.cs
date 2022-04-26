using Restauracja.Widok.Waiter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restauracja.Widok
{
    public partial class WaiterView : Form
    {
        private List<OrderToDeliver> orders = new List<OrderToDeliver>();
        private List<TableView> tablesView = new List<TableView>();
        private Model.Waiter waiter = new Model.Waiter();
        public WaiterView()
        {
            InitializeComponent();

            foreach(var x in waiter.getTableList())
            {
                tablesView.Add(new TableView(x) { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None });
            }
            foreach (var x in waiter.getOrdersToDelivery())
            {
                orders.Add(new OrderToDeliver(x) { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None });
            }
        }

        private void WaiterView_Load(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            foreach (var i in tablesView)
            {
                panelDisplay.Controls.Add(i);
                i.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            foreach (var i in orders)
            {
                panelDisplay.Controls.Add(i);
                i.buttonDelivered.Click += new EventHandler((s, ee) => ButtonDelivered_Click(s, ee, i.id));
                i.Show();
            }
        }

        private void buttonTables_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            foreach (var i in tablesView)
            {
                panelDisplay.Controls.Add(i);
                i.Show();
            }
        }

        private void ButtonDelivered_Click(object sender, EventArgs e, int id)
        {
            int rm = 0;
            foreach (var x in orders)
            {

                if (x.id == id)
                {
                    x.Close();
                    break;
                }
                rm++;
            }
            orders.RemoveAt(rm);
            waiter.orderDelivered(id);
        }

    }
}
