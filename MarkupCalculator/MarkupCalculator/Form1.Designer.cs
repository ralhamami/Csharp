namespace MarkupCalculator
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
            this.txtUserEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcCost = new System.Windows.Forms.Button();
            this.btnCalcPrice = new System.Windows.Forms.Button();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserEntry
            // 
            this.txtUserEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEntry.Location = new System.Drawing.Point(163, 41);
            this.txtUserEntry.Name = "txtUserEntry";
            this.txtUserEntry.Size = new System.Drawing.Size(100, 26);
            this.txtUserEntry.TabIndex = 0;
            this.txtUserEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter either Cost or Price below";
            // 
            // btnCalcCost
            // 
            this.btnCalcCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcCost.Location = new System.Drawing.Point(102, 164);
            this.btnCalcCost.Name = "btnCalcCost";
            this.btnCalcCost.Size = new System.Drawing.Size(238, 35);
            this.btnCalcCost.TabIndex = 2;
            this.btnCalcCost.Text = "Calculate Cost based on Price";
            this.btnCalcCost.UseVisualStyleBackColor = true;
            this.btnCalcCost.Click += new System.EventHandler(this.btnCalcCost_Click);
            // 
            // btnCalcPrice
            // 
            this.btnCalcPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcPrice.Location = new System.Drawing.Point(102, 205);
            this.btnCalcPrice.Name = "btnCalcPrice";
            this.btnCalcPrice.Size = new System.Drawing.Size(238, 35);
            this.btnCalcPrice.TabIndex = 3;
            this.btnCalcPrice.Text = "Calculate Price based on Cost";
            this.btnCalcPrice.UseVisualStyleBackColor = true;
            this.btnCalcPrice.Click += new System.EventHandler(this.btnCalcPrice_Click);
            // 
            // txtMarkup
            // 
            this.txtMarkup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkup.Location = new System.Drawing.Point(177, 120);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMarkup.Size = new System.Drawing.Size(60, 26);
            this.txtMarkup.TabIndex = 4;
            this.txtMarkup.Text = "45";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Based on Markup %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarkup);
            this.Controls.Add(this.btnCalcPrice);
            this.Controls.Add(this.btnCalcCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserEntry);
            this.Name = "Form1";
            this.Text = "Markup Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcCost;
        private System.Windows.Forms.Button btnCalcPrice;
        private System.Windows.Forms.TextBox txtMarkup;
        private System.Windows.Forms.Label label2;
    }
}

