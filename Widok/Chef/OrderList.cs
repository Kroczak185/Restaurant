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
    public partial class OrderList : Form
    {
        public OrderList(Model.Item i)
        {
            InitializeComponent();
            nameOfItem.Text = i.Name;
            picture.Image = i.Picture;
        }
    }
}
