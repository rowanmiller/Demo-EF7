namespace CycleSalesInternalApp
{
    partial class WarrantyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupWarrantyDetails = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.warrantyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.but_Lookup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textModelNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSerialNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupWarrantyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warrantyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupWarrantyDetails
            // 
            this.groupWarrantyDetails.Controls.Add(this.labelInfo);
            this.groupWarrantyDetails.Controls.Add(this.buttonSave);
            this.groupWarrantyDetails.Controls.Add(this.label2);
            this.groupWarrantyDetails.Controls.Add(this.textBox2);
            this.groupWarrantyDetails.Controls.Add(this.dateTimePicker1);
            this.groupWarrantyDetails.Controls.Add(this.label8);
            this.groupWarrantyDetails.Controls.Add(this.label4);
            this.groupWarrantyDetails.Controls.Add(this.numericUpDown1);
            this.groupWarrantyDetails.Controls.Add(this.label5);
            this.groupWarrantyDetails.Controls.Add(this.textBox1);
            this.groupWarrantyDetails.Controls.Add(this.label6);
            this.groupWarrantyDetails.Controls.Add(this.label7);
            this.groupWarrantyDetails.Location = new System.Drawing.Point(32, 142);
            this.groupWarrantyDetails.Margin = new System.Windows.Forms.Padding(6);
            this.groupWarrantyDetails.Name = "groupWarrantyDetails";
            this.groupWarrantyDetails.Padding = new System.Windows.Forms.Padding(6);
            this.groupWarrantyDetails.Size = new System.Drawing.Size(513, 556);
            this.groupWarrantyDetails.TabIndex = 22;
            this.groupWarrantyDetails.TabStop = false;
            this.groupWarrantyDetails.Text = "Warranty Details";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(9, 28);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(51, 20);
            this.labelInfo.TabIndex = 23;
            this.labelInfo.Text = "label9";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(161, 491);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 33);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date Sold:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warrantyBindingSource, "Notes", true));
            this.textBox2.Location = new System.Drawing.Point(161, 236);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(329, 243);
            this.textBox2.TabIndex = 15;
            // 
            // warrantyBindingSource
            // 
            this.warrantyBindingSource.DataSource = typeof(CycleSales.WarrantyModel.WarrantyInfo);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.warrantyBindingSource, "DateSold", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 77);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 29);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warrantyBindingSource, "Expires", true));
            this.label8.Location = new System.Drawing.Point(159, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "expirationDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Retailer:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.warrantyBindingSource, "WarrantyYears", true));
            this.numericUpDown1.Location = new System.Drawing.Point(161, 159);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 29);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Warranty Years:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warrantyBindingSource, "Retailer", true));
            this.textBox1.Location = new System.Drawing.Point(161, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 29);
            this.textBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Expiry:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notes:";
            // 
            // but_Lookup
            // 
            this.but_Lookup.Location = new System.Drawing.Point(132, 96);
            this.but_Lookup.Margin = new System.Windows.Forms.Padding(6);
            this.but_Lookup.Name = "but_Lookup";
            this.but_Lookup.Size = new System.Drawing.Size(101, 34);
            this.but_Lookup.TabIndex = 2;
            this.but_Lookup.Text = "Lookup";
            this.but_Lookup.UseVisualStyleBackColor = true;
            this.but_Lookup.Click += new System.EventHandler(this.buttonLookup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Serial No:";
            // 
            // textModelNo
            // 
            this.textModelNo.Location = new System.Drawing.Point(132, 14);
            this.textModelNo.Margin = new System.Windows.Forms.Padding(6);
            this.textModelNo.Name = "textModelNo";
            this.textModelNo.Size = new System.Drawing.Size(231, 29);
            this.textModelNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Model No:";
            // 
            // textSerialNo
            // 
            this.textSerialNo.Location = new System.Drawing.Point(132, 55);
            this.textSerialNo.Margin = new System.Windows.Forms.Padding(6);
            this.textSerialNo.Name = "textSerialNo";
            this.textSerialNo.Size = new System.Drawing.Size(231, 29);
            this.textSerialNo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Hint: try TTT200 and FR12789";
            // 
            // WarrantyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 713);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupWarrantyDetails);
            this.Controls.Add(this.but_Lookup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textModelNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSerialNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WarrantyForm";
            this.Text = "WarrantyForm";
            this.groupWarrantyDetails.ResumeLayout(false);
            this.groupWarrantyDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warrantyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupWarrantyDetails;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button but_Lookup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textModelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSerialNo;
        private System.Windows.Forms.BindingSource warrantyBindingSource;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label9;

    }
}