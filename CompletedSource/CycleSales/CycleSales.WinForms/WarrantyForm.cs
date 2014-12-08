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
    public partial class WarrantyForm : Form
    {
        private WarrantyContext _context = new WarrantyContext();

        public WarrantyForm()
        {
            InitializeComponent();

            this.groupWarrantyDetails.Visible = false;
        }

        private void buttonLookup_Click(object sender, EventArgs e)
        {
            var warranty = _context.Warranties
                .Where(w =>
                    w.BikeModelNo == this.textModelNo.Text
                    && w.BikeSerialNo == this.textSerialNo.Text)
                .SingleOrDefault();

            if(warranty == null)
            {
                warranty = new WarrantyInfo
                {
                    BikeModelNo = this.textModelNo.Text,
                    BikeSerialNo = this.textSerialNo.Text,
                    DateSold = DateTime.Today,
                    WarrantyYears = 1
                };

                _context.Warranties.Add(warranty);
                this.labelInfo.Text = "No prior warranty information found. Please enter the information.";
            }
            else
            {
                this.labelInfo.Text = "Existing warranty information found for this bike.";
            }

            if (warranty != null)
            {
                this.warrantyBindingSource.DataSource = warranty;
                this.groupWarrantyDetails.Visible = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
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
