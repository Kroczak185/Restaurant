using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja.Widok.Chef
{
    public partial class OrderView : Form
    {
        private DateTime dateTime;
        private Model.Chef chef = new Model.Chef();
        private int idOrder;
        public OrderView(int idZamowienia, DateTime czas, List<OrderList> orderLists)
        {
            InitializeComponent();
            dateTime = czas;
            idOrder = idZamowienia;
            labelCzas.Text = dateTime.Subtract(System.DateTime.Now).ToString(@"hh\:mm\:ss");
            if (dateTime.Subtract(System.DateTime.Now).TotalSeconds < 0)
            {
                BackColor = Color.OrangeRed;
                labelCzas.Text += " late";
            }
            else if (dateTime.Subtract(System.DateTime.Now).TotalMinutes < 60)
            {
                BackColor = Color.Orange;
            }
            labelIdZamowienia.Text = idZamowienia.ToString();
            foreach(var x in orderLists)
            {
                orderList.Controls.Add(x);
                x.Show();
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chef.addToFinished(idOrder);
            timer1.Stop();
            timer1.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCzas.Text = dateTime.Subtract(System.DateTime.Now).ToString(@"hh\:mm\:ss");
            if (dateTime.Subtract(System.DateTime.Now).TotalSeconds < 0)
            {
                BackColor = Color.OrangeRed;
                labelCzas.Text += " late";
            }
            else if (dateTime.Subtract(System.DateTime.Now).TotalMinutes < 60)
            {
                BackColor = Color.Orange;
            }
            if (dateTime.Subtract(System.DateTime.Now).TotalSeconds >= 3599 && dateTime.Subtract(System.DateTime.Now).TotalSeconds < 3600)
            {
                MessageBox.Show("Order number "+ idOrder + " should be ready in 1 hour!");
            }
        }
    }
}
