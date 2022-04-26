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
    public partial class CustomerViewTables : Form
    {
        public CustomerViewTables()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
            datePicker.MinDate = DateTime.Now;
        }

    }
}
