using Restauracja.Model;
using Restauracja.Widok.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Restauracja
{
    public partial class CustomerView : Form
    {
        private Customer customer = new Customer();

        private List<CustomerViewMenu> customeritems = new List<CustomerViewMenu>();
        private List<CustomerViewCart> customercartitems = new List<CustomerViewCart>();
        private List<Restauracja.Model.Item> cart = new List<Restauracja.Model.Item>();
        private CustomerViewTables customerViewTables = new CustomerViewTables() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        private List<Tables> tables = new List<Tables>();
        private CustomerViewEnd customerViewEnd = new CustomerViewEnd() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };


        public CustomerView()
        {
            InitializeComponent();
            tables.Add(new Tables(0, 0) { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None });
            tables[0].label1.Text = "Take away";
            tables[0].label.Text = "";
            tables[0].labelTableId.Text = "";
            tables[0].isChecked = true;
            foreach (var t in customer.getTableList())
            {
                if(t.status == Status.Free)
                tables.Add(new Tables(t.Id, t.People) { TopLevel = false, TopMost = true });
            }
            CustomerButtonRightPanel.Enabled = false;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            //TODO load item list from database
            foreach (var x in customer.getMenu())
            {
                customeritems.Add(new CustomerViewMenu(x) { TopLevel = false, TopMost = true });
            }
            int w = 0;
            foreach (var z in customeritems)
            {
                z.FormBorderStyle = FormBorderStyle.None;
                CustomerLeftFlowPanel.Controls.Add(z);
                z.Show();
                z.indexx = w;
                int temp = z.indexx;
                z.MenuItemPicturebox.Click += new EventHandler((s, ee) => CustomerMenuItem_Click(s, ee, temp));
                z.ManuLabelName.Click += new EventHandler((s, ee) => CustomerMenuItem_Click(s, ee, temp));
                z.ManuLabelPrize.Click += new EventHandler((s, ee) => CustomerMenuItem_Click(s, ee, temp));
                z.MenuZLLabel.Click += new EventHandler((s, ee) => CustomerMenuItem_Click(s, ee, temp));
                w++;
            }


            foreach (var z in tables)
            {
                int temp = z.tableID;
                z.Click += new EventHandler((s, ee) => Table_Click(s, ee, temp));
                z.pictureBox.Click += new EventHandler((s, ee) => Table_Click(s, ee, temp));
                z.label.Click += new EventHandler((s, ee) => Table_Click(s, ee, temp));
                z.topPanel.Click += new EventHandler((s, ee) => Table_Click(s, ee, temp));
                z.label1.Click += new EventHandler((s, ee) => Table_Click(s, ee, temp));
                z.labelTableId.Click += new EventHandler((s, ee) => Table_Click(s, ee, temp));
                z.bottomPanel.Click += new EventHandler((s, ee) => Table_Click(s, ee, temp));
                z.labelPlacesToSeat.Click += new EventHandler((s, ee) => Table_Click(s, ee, temp));
            }

            customerViewTables.buttonEnd.Click += new System.EventHandler(this.TablesNext_Click);
            customerViewEnd.labelEnd.Click += new System.EventHandler(this.EndRestart_Click);
        }

        private float CartSummary()
        {
            float p = 0f;
            foreach (var t in customercartitems)
            {
                p += float.Parse(t.CartPrizeLabel.Text.ToString());

            }
            return p;
        }

        private int CheckIfIsInCart(int index)
        {
            for (int x = 0; x <= customercartitems.Count - 1; x++)
            {
                if (customercartitems[x].indexx == index)
                    return x;
            }
            return -1;
        }

        private void CustomerMenuItem_Click(object sender, EventArgs e, int x)
        {
            int check = CheckIfIsInCart(x);
            if (check == -1)
            {
                int temp = customercartitems.Count;
                customercartitems.Add(new CustomerViewCart(customeritems[x].item) { TopLevel = false, TopMost = true });
                customercartitems[temp].FormBorderStyle = FormBorderStyle.None;
                customercartitems[temp].indexx = customeritems[x].indexx;
                customercartitems[temp].CartPicturebox.Image = customeritems[x].MenuItemPicturebox.Image;
                customercartitems[temp].CartNameLabel.Text = customeritems[x].ManuLabelName.Text;
                customercartitems[temp].CartPrizeLabel.Text = customeritems[x].ManuLabelPrize.Text;
                customercartitems[temp].prize = float.Parse(customeritems[x].ManuLabelPrize.Text.ToString());
                CustomerRightFlowPanel.Controls.Add(customercartitems[temp]);
                customercartitems[temp].Show();
                customercartitems[temp].CartButton.Click += new EventHandler((s, ee) => CartItemDelete_Click(s, ee, temp));
                customercartitems[temp].CartItemNumberLabel.TextChanged += new EventHandler((s, ee) => CartItemNumerChanged(s, ee, temp));
                CustomerPriceLabel.Text = CartSummary().ToString();
            }
            else
            {
                float w = float.Parse(customercartitems[check].CartItemNumberLabel.Text.ToString());
                w++;
                customercartitems[check].CartItemNumberLabel.Text = w.ToString();
            }
            CustomerButtonRightPanel.Enabled = true;
            CheckIfCartEmpty();
        }

        private void Table_Click(object sender, EventArgs e, int x)
        {
            foreach (var z in tables)
            {
                z.isChecked = false;
                z.BackColor = Color.White;
                z.label.BackColor = Color.White;
                z.label1.BackColor = Color.White;
                z.labelTableId.BackColor = Color.White;
                z.topPanel.BackColor = Color.White;
                z.pictureBox.BackColor = Color.White;
                z.labelPlacesToSeat.BackColor = Color.White;
                z.bottomPanel.BackColor = Color.White;

            }
            tables[x].isChecked = true;
            tables[x].BackColor = Color.Black;
        }

        public void RemoveHandlerList(Control c)
        {
            EventHandlerList list = (EventHandlerList)typeof(Control).GetProperty("Events", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(c, null);
            typeof(EventHandlerList).GetMethod("Dispose").Invoke(list, null);
        }

        private void CartItemDelete_Click(object sender, EventArgs e, int x)
        {
            for (int w = 0; w <= customercartitems.Count - 1; w++)
            {
                int temp = w;
                RemoveHandlerList(customercartitems[temp].CartButton);
                RemoveHandlerList(customercartitems[temp].CartItemNumberLabel);
            }
            customercartitems[x].Close();
            customercartitems[x] = null;
            customercartitems.RemoveAt(x);
            CustomerPriceLabel.Text = CartSummary().ToString();
            for (int w = 0; w <= customercartitems.Count - 1; w++)
            {
                int temp = w;
                customercartitems[w].CartButton.Click += (s, ee) => CartItemDelete_Click(s, ee, temp);
                customercartitems[temp].CartItemNumberLabel.TextChanged += new EventHandler((s, ee) => CartItemNumerChanged(s, ee, temp));
            }
            CheckIfCartEmpty();
        }

        private void CheckIfCartEmpty()
        {
            if(customercartitems.Count == 0)
            CustomerButtonRightPanel.Enabled = false;
        }

        private void CartItemNumerChanged(object sender, EventArgs e, int x)
        {
            int temp = x;
            if (Int32.Parse(customercartitems[temp].CartItemNumberLabel.Text.ToString()) <= 0)
            {
                CartItemDelete_Click(sender, e, temp);
            }
            else
            {
                float z = customercartitems[temp].prize * float.Parse(customercartitems[temp].CartItemNumberLabel.Text.ToString());
                customercartitems[temp].CartPrizeLabel.Text = z.ToString("0.00");
                CustomerPriceLabel.Text = CartSummary().ToString();
            }
            CheckIfCartEmpty();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CustomerButtonRightPanel_Click(object sender, EventArgs e)
        {
            BottomFillPanel.Controls.Clear();
            BottomFillPanel.Controls.Add(customerViewTables);
            customerViewTables.Show();
            CustomerTopLabel.Text = "Pick time and table";
            customerViewTables.flowPanel.Controls.Clear();
            foreach (var i in customercartitems)
            {
                for(int y=0;y<Int32.Parse(i.CartItemNumberLabel.Text); y++)
                cart.Add(new Model.Item(i.item.Id, i.item.Name, i.item.Price, i.item.Picture));
            }
            foreach (var x in tables)
            {
                customerViewTables.flowPanel.Controls.Add(x);
                x.Show();
            }
            customer.setCart(cart);
        }

        private void TablesNext_Click(object sender, EventArgs e)
        {
            if (customerViewTables.datePicker.Value.CompareTo(DateTime.Now)<=0 || customerViewTables.datePicker.Value.CompareTo(DateTime.Now.AddDays(1)) > 0)
                MessageBox.Show("Wybrano niewłaściwą datę!","Wystąpił błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                CustomerTopLabel.Text = "Thank you for your order!";
                BottomFillPanel.Controls.Clear();
                BottomFillPanel.Controls.Add(customerViewEnd);
                customerViewEnd.Show();

                Restauracja.Model.Table t;
                if (tables[0].isChecked == true)
                {
                    t = null;
                    customer.createOrder(customerViewTables.datePicker.Value, t);
                }
                else
                {
                    foreach (var x in tables)
                    {
                        if (x.isChecked == true)
                        {
                            t = new Restauracja.Model.Table(x.tableID, Status.Reserved, x.people);
                            customer.createOrder(customerViewTables.datePicker.Value, t);
                        }
                    }
                }
            }
        }

        private void EndRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
