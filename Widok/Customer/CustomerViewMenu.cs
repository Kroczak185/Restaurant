using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restauracja
{
    public partial class CustomerViewMenu : Form
    {
        public Model.Item item;
        public CustomerViewMenu(Model.Item i)
        {
            item = i;
            InitializeComponent();
            ManuLabelName.Text = i.Name;
            ManuLabelPrize.Text = i.Price.ToString("0.00");
            MenuItemPicturebox.Image = i.Picture;
        }

        private void MenuItemPicturebox_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void MenuItemPicturebox_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }
    }
}
