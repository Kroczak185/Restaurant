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
    public partial class Products : Form
    {
        public float sumPrice = 0f;
        public Products(Model.Item i)
        {
            InitializeComponent();
            picture.Image = i.Picture;
            priceLabel.Text = i.Price.ToString("0.00");
            nameLabel.Text = i.Name;
            sumPrice = i.Price;
        }
    }
}
