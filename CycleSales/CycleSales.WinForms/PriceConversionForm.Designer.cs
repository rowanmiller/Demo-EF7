namespace CycleSalesInternalApp
{
    partial class PriceConversionForm
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
            this.textExchangeRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colBikeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForeignPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textExchangeRate
            // 
            this.textExchangeRate.Location = new System.Drawing.Point(13, 8);
            this.textExchangeRate.Name = "textExchangeRate";
            this.textExchangeRate.Size = new System.Drawing.Size(70, 29);
            this.textExchangeRate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "<foreign unit> = 1 USD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBikeName,
            this.colUSPrice,
            this.colForeignPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 436);
            this.dataGridView1.TabIndex = 4;
            // 
            // colBikeName
            // 
            this.colBikeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBikeName.DataPropertyName = "BikeName";
            this.colBikeName.HeaderText = "Bike";
            this.colBikeName.Name = "colBikeName";
            this.colBikeName.Width = 71;
            // 
            // colUSPrice
            // 
            this.colUSPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUSPrice.DataPropertyName = "USPrice";
            this.colUSPrice.HeaderText = "US Price";
            this.colUSPrice.Name = "colUSPrice";
            this.colUSPrice.Width = 108;
            // 
            // colForeignPrice
            // 
            this.colForeignPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colForeignPrice.DataPropertyName = "ForeignPrice";
            this.colForeignPrice.HeaderText = "Foreign Price";
            this.colForeignPrice.Name = "colForeignPrice";
            this.colForeignPrice.Width = 149;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(290, 8);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(99, 29);
            this.buttonGo.TabIndex = 5;
            this.buttonGo.Text = "Convert";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textExchangeRate);
            this.panel1.Controls.Add(this.buttonGo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 46);
            this.panel1.TabIndex = 6;
            // 
            // PriceConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PriceConversionForm";
            this.Text = "Price Convertor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textExchangeRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBikeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUSPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForeignPrice;
        private System.Windows.Forms.Panel panel1;
    }
}