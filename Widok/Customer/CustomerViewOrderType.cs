using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja.Widok.Customer
{
    public partial class CustomerViewOrderType : Form
    {
        public CustomerViewOrderType()
        {
            InitializeComponent();
        }

        private void right_MouseEnter(object sender, EventArgs e)
        {
            rightLabel.BackColor = Color.Gray;
            rightPicturebox.BackColor = Color.Gray;
            rightPanel.BackColor = Color.Gray;
        }

        private void left_MouseEnter(object sender, EventArgs e)
        {
            leftLabel.BackColor = Color.Gray;
            leftPicturebox.BackColor = Color.Gray;
            leftPanel.BackColor = Color.Gray;
        }

        private void left_MouseLeave(object sender, EventArgs e)
        {
            leftLabel.BackColor = Color.White;
            leftPicturebox.BackColor = Color.White;
            leftPanel.BackColor = Color.White;
        }

        private void right_MouseLeave(object sender, EventArgs e)
        {
            rightLabel.BackColor = Color.White;
            rightPicturebox.BackColor = Color.White;
            rightPanel.BackColor = Color.White;
        }

        private void rightPicturebox_Click(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
