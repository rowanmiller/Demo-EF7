using CycleSales.CycleSalesModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CycleSalesInternalApp
{
    public partial class BikesForm : Form
    {
        private CycleSalesContext _context = new CycleSalesContext();

        public BikesForm()
        {
            InitializeComponent();

            this.bikeBindingSource.DataSource = _context.Bikes.ToList();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
