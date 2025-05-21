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
    public partial class FrmSalesEntry : Form
    {
        public FrmSalesEntry()
        {
            InitializeComponent();
        }


        private void FrmSalesEntry_Load(object sender, EventArgs e)
        {
            var items = DatabaseHelper.LoadItems();
            cmbItems.DataSource = items;
            cmbItems.DisplayMember = "Name";
            cmbItems.ValueMember = "ItemGuid";

            LoadSales();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItems.SelectedItem is SaleItem selectedItem)
            {
                lblPrice.Text = selectedItem.UnitPrice.ToString("0.00");
                CalculateTotals();
            }
        }


        private void CalculateTotals()
        {
            if (cmbItems.SelectedItem is SaleItem selectedItem)
            {
                int qty = (int)numQty.Value;
                selectedItem.Quantity = qty;

                lblSubTotal.Text = selectedItem.SubTotal.ToString("0.00");
                lblVAT.Text = selectedItem.VAT.ToString("0.00");
                lblTotal.Text = selectedItem.Total.ToString("0.00");
            }
        }


        private void LoadSales()
        {
            var dt = DatabaseHelper.GetSalesByDate(DateTime.Today, DateTime.Today.AddDays(1));
            dgvSales.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedItem is SaleItem selectedItem)
            {
                selectedItem.Quantity = (int)numQty.Value;

                if (selectedItem.Quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than 0");
                    return;
                }

                DatabaseHelper.InsertSale(selectedItem);

                Logger.Log($"Saved Sale: '{selectedItem.Name}', Qty={selectedItem.Quantity}, Total={selectedItem.Total.ToString("0.00")} JOD");

                MessageBox.Show("Sale saved successfully.");

                LoadSales();
            }
        }

        private void numQty_ValueChanged_1(object sender, EventArgs e)
        {
            CalculateTotals();

        }
    }
}
