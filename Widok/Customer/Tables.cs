using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restauracja.Widok.Customer
{
    public partial class Tables : Form
    {
        public bool isChecked = false;
        public int tableID;
        public int people;
        public Tables(int id, int placesToSit)
        {
            InitializeComponent();
            people = placesToSit;
            tableID = id;
            labelPlacesToSeat.Text = placesToSit.ToString();
            labelTableId.Text = id.ToString();
            System.IO.DirectoryInfo filepathtemp = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString());
            string filepath = filepathtemp.ToString() + @"\Widok\images\";
            switch (placesToSit)
            {
                case 0:
                    pictureBox.Image = Image.FromFile(filepath + "takeaway.png");
                    labelPlacesToSeat.Text = "";
                    label1.Text = "Take away";
                    label.Text = "";
                    labelTableId.Text = "";
                    isChecked = true;
                    break;
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

        private void Tables_MouseEnter(object sender, EventArgs e)
        {
            if (!isChecked)
            {
                label.BackColor = Color.LightGray;
                label1.BackColor = Color.LightGray;
                labelTableId.BackColor = Color.LightGray;
                pictureBox.BackColor = Color.LightGray;
                BackColor = Color.LightGray;
                labelPlacesToSeat.BackColor = Color.LightGray;
                bottomPanel.BackColor = Color.LightGray;
            }
        }

        private void Tables_Leave(object sender, EventArgs e)
        {
            if (!isChecked)
            {
                label.BackColor = Color.White;
                label1.BackColor = Color.White;
                labelTableId.BackColor = Color.White;
                pictureBox.BackColor = Color.White;
                BackColor = Color.White;
                labelPlacesToSeat.BackColor = Color.White;
                bottomPanel.BackColor = Color.White;
            }
        }
    }
}
