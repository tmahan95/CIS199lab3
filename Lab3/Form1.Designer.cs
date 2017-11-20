namespace Lab3
{
    partial class gratuityCalcFormLab3
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.smallTipLabel = new System.Windows.Forms.Label();
            this.mediumTipLabel = new System.Windows.Forms.Label();
            this.largeTipLabel = new System.Windows.Forms.Label();
            this.smallTipDisplayLabel = new System.Windows.Forms.Label();
            this.mediumTipDisplayLabel = new System.Windows.Forms.Label();
            this.largeTipDisplayLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.tipCalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(54, 38);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(62, 13);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Enter Price:";
            // 
            // smallTipLabel
            // 
            this.smallTipLabel.AutoSize = true;
            this.smallTipLabel.Location = new System.Drawing.Point(54, 84);
            this.smallTipLabel.Name = "smallTipLabel";
            this.smallTipLabel.Size = new System.Drawing.Size(69, 13);
            this.smallTipLabel.TabIndex = 1;
            this.smallTipLabel.Text = "Gratuity: 15%";
            // 
            // mediumTipLabel
            // 
            this.mediumTipLabel.AutoSize = true;
            this.mediumTipLabel.Location = new System.Drawing.Point(54, 135);
            this.mediumTipLabel.Name = "mediumTipLabel";
            this.mediumTipLabel.Size = new System.Drawing.Size(69, 13);
            this.mediumTipLabel.TabIndex = 2;
            this.mediumTipLabel.Text = "Gratuity: 18%";
            // 
            // largeTipLabel
            // 
            this.largeTipLabel.AutoSize = true;
            this.largeTipLabel.Location = new System.Drawing.Point(54, 183);
            this.largeTipLabel.Name = "largeTipLabel";
            this.largeTipLabel.Size = new System.Drawing.Size(69, 13);
            this.largeTipLabel.TabIndex = 3;
            this.largeTipLabel.Text = "Gratuity: 20%";
            // 
            // smallTipDisplayLabel
            // 
            this.smallTipDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallTipDisplayLabel.Location = new System.Drawing.Point(164, 83);
            this.smallTipDisplayLabel.Name = "smallTipDisplayLabel";
            this.smallTipDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.smallTipDisplayLabel.TabIndex = 4;
            // 
            // mediumTipDisplayLabel
            // 
            this.mediumTipDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediumTipDisplayLabel.Location = new System.Drawing.Point(164, 134);
            this.mediumTipDisplayLabel.Name = "mediumTipDisplayLabel";
            this.mediumTipDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.mediumTipDisplayLabel.TabIndex = 5;
            // 
            // largeTipDisplayLabel
            // 
            this.largeTipDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeTipDisplayLabel.Location = new System.Drawing.Point(164, 182);
            this.largeTipDisplayLabel.Name = "largeTipDisplayLabel";
            this.largeTipDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.largeTipDisplayLabel.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(164, 35);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // tipCalcButton
            // 
            this.tipCalcButton.Location = new System.Drawing.Point(106, 229);
            this.tipCalcButton.Name = "tipCalcButton";
            this.tipCalcButton.Size = new System.Drawing.Size(75, 23);
            this.tipCalcButton.TabIndex = 8;
            this.tipCalcButton.Text = "Calculate Tip";
            this.tipCalcButton.UseVisualStyleBackColor = true;
            this.tipCalcButton.Click += new System.EventHandler(this.tipCalcButton_Click);
            // 
            // gratuityCalcFormLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 280);
            this.Controls.Add(this.tipCalcButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.largeTipDisplayLabel);
            this.Controls.Add(this.mediumTipDisplayLabel);
            this.Controls.Add(this.smallTipDisplayLabel);
            this.Controls.Add(this.largeTipLabel);
            this.Controls.Add(this.mediumTipLabel);
            this.Controls.Add(this.smallTipLabel);
            this.Controls.Add(this.priceLabel);
            this.Name = "gratuityCalcFormLab3";
            this.Text = "Lab3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label smallTipLabel;
        private System.Windows.Forms.Label mediumTipLabel;
        private System.Windows.Forms.Label largeTipLabel;
        private System.Windows.Forms.Label smallTipDisplayLabel;
        private System.Windows.Forms.Label mediumTipDisplayLabel;
        private System.Windows.Forms.Label largeTipDisplayLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button tipCalcButton;
    }
}

