using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja.Widok.Waiter
{
    public partial class OrderToDeliver : Form
    {
        List<Products> products = new List<Products>();
        public int id;
        public OrderToDeliver(Model.Order o)
        {
            InitializeComponent();
            id = o.Id;
          if(o.Choosen_table !=null)
                tableNumber.Text = "TableView number: " + o.Choosen_table.Id.ToString();

            else
                tableNumber.Text = "Take away";

            orderID.Text = "Order ID: " + o.Id.ToString();
            var pr = 0f;
            foreach (var i in o.Food)
            {
                products.Add(new Products(i) { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None });
            }
            foreach (var i in products)
            {
                orderListPanel.Controls.Add(i);
                i.Show();
                pr += i.sumPrice;
            }
            price.Text = "Summary price: " + pr.ToString("0.00")+" zł";
        }
    }
}
