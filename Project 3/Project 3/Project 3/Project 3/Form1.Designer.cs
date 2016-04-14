namespace Project_3
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtFICO = new System.Windows.Forms.TextBox();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAvgFICO = new System.Windows.Forms.TextBox();
            this.txtAvgSavings = new System.Windows.Forms.TextBox();
            this.txtMedFICO = new System.Windows.Forms.TextBox();
            this.txtMedSavings = new System.Windows.Forms.TextBox();
            this.txtBestFICO = new System.Windows.Forms.TextBox();
            this.txtBestSavings = new System.Windows.Forms.TextBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(213, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(91, 28);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(116, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtFICO
            // 
            this.txtFICO.Location = new System.Drawing.Point(91, 55);
            this.txtFICO.Name = "txtFICO";
            this.txtFICO.Size = new System.Drawing.Size(116, 20);
            this.txtFICO.TabIndex = 2;
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(91, 81);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.Size = new System.Drawing.Size(116, 20);
            this.txtSavings.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "FICO Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Savings Balance";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average FICO";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Average Savings";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Median FICO";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Median Savings";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(35, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Best FICO";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(21, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Best Savings";
            // 
            // txtAvgFICO
            // 
            this.txtAvgFICO.Enabled = false;
            this.txtAvgFICO.Location = new System.Drawing.Point(91, 111);
            this.txtAvgFICO.Name = "txtAvgFICO";
            this.txtAvgFICO.Size = new System.Drawing.Size(116, 20);
            this.txtAvgFICO.TabIndex = 13;
            // 
            // txtAvgSavings
            // 
            this.txtAvgSavings.Enabled = false;
            this.txtAvgSavings.Location = new System.Drawing.Point(91, 134);
            this.txtAvgSavings.Name = "txtAvgSavings";
            this.txtAvgSavings.Size = new System.Drawing.Size(116, 20);
            this.txtAvgSavings.TabIndex = 14;
            // 
            // txtMedFICO
            // 
            this.txtMedFICO.Enabled = false;
            this.txtMedFICO.Location = new System.Drawing.Point(91, 157);
            this.txtMedFICO.Name = "txtMedFICO";
            this.txtMedFICO.Size = new System.Drawing.Size(116, 20);
            this.txtMedFICO.TabIndex = 15;
            // 
            // txtMedSavings
            // 
            this.txtMedSavings.Enabled = false;
            this.txtMedSavings.Location = new System.Drawing.Point(91, 180);
            this.txtMedSavings.Name = "txtMedSavings";
            this.txtMedSavings.Size = new System.Drawing.Size(116, 20);
            this.txtMedSavings.TabIndex = 16;
            // 
            // txtBestFICO
            // 
            this.txtBestFICO.Enabled = false;
            this.txtBestFICO.Location = new System.Drawing.Point(91, 203);
            this.txtBestFICO.Name = "txtBestFICO";
            this.txtBestFICO.Size = new System.Drawing.Size(116, 20);
            this.txtBestFICO.TabIndex = 17;
            // 
            // txtBestSavings
            // 
            this.txtBestSavings.Enabled = false;
            this.txtBestSavings.Location = new System.Drawing.Point(91, 226);
            this.txtBestSavings.Name = "txtBestSavings";
            this.txtBestSavings.Size = new System.Drawing.Size(116, 20);
            this.txtBestSavings.TabIndex = 18;
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(213, 59);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(156, 186);
            this.lstCustomers.TabIndex = 19;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(294, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 22;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.txtBestSavings);
            this.Controls.Add(this.txtBestFICO);
            this.Controls.Add(this.txtMedSavings);
            this.Controls.Add(this.txtMedFICO);
            this.Controls.Add(this.txtAvgSavings);
            this.Controls.Add(this.txtAvgFICO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSavings);
            this.Controls.Add(this.txtFICO);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtFICO;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAvgFICO;
        private System.Windows.Forms.TextBox txtAvgSavings;
        private System.Windows.Forms.TextBox txtMedFICO;
        private System.Windows.Forms.TextBox txtMedSavings;
        private System.Windows.Forms.TextBox txtBestFICO;
        private System.Windows.Forms.TextBox txtBestSavings;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

