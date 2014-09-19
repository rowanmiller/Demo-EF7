using CycleSales.CycleSalesModel;
using CycleSales.WarrantyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleSalesInternalApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BikesForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void warrantyLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new WarrantyForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void convertPricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PriceConversionForm();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
