using System.Collections.Generic;
using System.Windows.Forms;
using Restauracja.Widok.Chef;

namespace Restauracja.Widok
{
   
    public partial class ChefView : Form
    {
        private Model.Chef chef = new Model.Chef();
        private List<OrderView> orderLists = new List<OrderView>();

        public ChefView()
        {
            InitializeComponent();
            List<Model.Order> ordersToCook = chef.getOrdersToCook();
            
            foreach (var x in ordersToCook)
            {
                List<OrderList> ol = new List<OrderList>();
                foreach (var z in x.Food)
                {
                    ol.Add(new OrderList(z) { TopLevel = false, TopMost = true });
                }
                orderLists.Add(new OrderView(x.Id, x.Time, ol) { TopLevel = false, TopMost = true });
            }
            foreach(var x in orderLists)
            {
                panelZamowienia.Controls.Add(x);
                x.Show();
            }
        }
        private void back_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }
    }
}
