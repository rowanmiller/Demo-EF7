using CycleSales.CycleSalesModel;
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
    public partial class PriceConversionForm : Form
    {
        public PriceConversionForm()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            var exchangeRate = decimal.Parse(this.textExchangeRate.Text);

            using (var db = new CycleSalesContext())
            {
                var convertor = new PriceService(db);
                this.dataGridView1.DataSource = convertor.CalculateForeignPrices(exchangeRate);
            }
        }
    }
}
