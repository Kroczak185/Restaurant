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
    public partial class TableView : Form
    { private Model.Table table = new Model.Table();
        private Model.Waiter w = new Model.Waiter();
        public TableView(Model.Table t)
        {
            table = t;
            InitializeComponent();
            labelID.Text = "Id: " + t.Id.ToString();
            switch(t.status)
            {
                case Model.Status.Free:
                    labelStatus.Text = "Free";
                    BackColor = Color.LightGreen;
                    break;
                case Model.Status.Reserved:
                    labelStatus.Text = "Reserved";
                    BackColor = Color.Orange;
                    break;
                case Model.Status.Occupied:
                    labelStatus.Text = "Occupied";
                    BackColor = Color.Red;
                    break;
            }
            System.IO.DirectoryInfo filepathtemp = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString());
            string filepath = filepathtemp.ToString() + @"\Widok\images\";
            switch (t.People)
            {
                case 2:
                    pictureBox.Image = Image.FromFile(filepath + "stolik2.png");
                    break;
                case 4:
                    pictureBox.Image = Image.FromFile(filepath + "stolik4.png");
                    break;
                case 6:
                    pictureBox.Image = Image.FromFile(filepath + "stolik6.png");
                    break;
                default:
                    pictureBox.Image = Image.FromFile(filepath + "stolik2.png");
                    break;
            }
        }

        private void buttonFree_Click(object sender, EventArgs e)
        {
            w.setTableFree(table);
            labelStatus.Text = "Free";
            BackColor = Color.LightGreen;
        }

        private void buttonReserved_Click(object sender, EventArgs e)
        {
            w.setTableReserved(table);
            labelStatus.Text = "Reseved";
            BackColor = Color.Orange;
        }

        private void buttonOccupied_Click(object sender, EventArgs e)
        {
            w.setTableOccupied(table);
            labelStatus.Text = "Occupied";
            BackColor = Color.Red;
        }
    }
}
