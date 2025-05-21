using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSalesApp
{
    public partial class FrmSalesReport : Form
    {
        public FrmSalesReport()
        {
            InitializeComponent();
        }
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            DateTime from = dtFrom.Value.Date;
            DateTime to = dtTo.Value.Date.AddDays(1).AddSeconds(-1); 

            DataTable dt = DatabaseHelper.GetSalesByDate(from, to);
            dgvReport.DataSource = dt;

            int totalQty = 0;
            decimal totalSub = 0;
            decimal totalVat = 0;
            decimal totalFinal = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalQty += Convert.ToInt32(row["Quantity"]);
                totalSub += Convert.ToDecimal(row["SubTotal"]);
                totalVat += Convert.ToDecimal(row["VAT"]);
                totalFinal += Convert.ToDecimal(row["Total"]);
            }

            lblTotalQty.Text = totalQty.ToString();
            lblSubTotal.Text = totalSub.ToString("0.00");
            lblVAT.Text = totalVat.ToString("0.00");
            lblTotalAmount.Text = totalFinal.ToString("0.00");
        }
    }
}
