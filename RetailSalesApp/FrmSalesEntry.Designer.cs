namespace RetailSalesApp
{
    partial class FrmSalesEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(12, 30);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(202, 24);
            this.cmbItems.TabIndex = 0;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(241, 33);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 22);
            this.numQty.TabIndex = 1;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged_1);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(413, 32);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "label1";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(504, 33);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(44, 16);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Text = "label1";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(588, 32);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(44, 16);
            this.lblVAT.TabIndex = 4;
            this.lblVAT.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(682, 33);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(767, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(12, 71);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(1203, 150);
            this.dgvSales.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "SubTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(682, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total";
            // 
            // FrmSalesEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 707);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.cmbItems);
            this.Name = "FrmSalesEntry";
            this.Text = "Sales Entry";
            this.Load += new System.EventHandler(this.FrmSalesEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

