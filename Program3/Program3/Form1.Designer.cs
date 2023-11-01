namespace Program3
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
            this.GardenLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.GardenInputlabel = new System.Windows.Forms.ComboBox();
            this.ItemNumberInputlabel = new System.Windows.Forms.TextBox();
            this.QuantityInputlabel = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FlowersCostLabel = new System.Windows.Forms.Label();
            this.BaseAdjustedCostLabel = new System.Windows.Forms.Label();
            this.DiscountPercentLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.flowerCostOutput = new System.Windows.Forms.Label();
            this.baseCostOutput = new System.Windows.Forms.Label();
            this.discountPercentOutput = new System.Windows.Forms.Label();
            this.totalPriceOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GardenLabel
            // 
            this.GardenLabel.AutoSize = true;
            this.GardenLabel.Location = new System.Drawing.Point(111, 25);
            this.GardenLabel.Name = "GardenLabel";
            this.GardenLabel.Size = new System.Drawing.Size(55, 16);
            this.GardenLabel.TabIndex = 0;
            this.GardenLabel.Text = "Garden:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(37, 63);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(129, 16);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "Entree/Item Number:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(108, 91);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(58, 16);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // GardenInputlabel
            // 
            this.GardenInputlabel.FormattingEnabled = true;
            this.GardenInputlabel.Items.AddRange(new object[] {
            "Premuim",
            "Stnadard",
            "Discount"});
            this.GardenInputlabel.Location = new System.Drawing.Point(175, 17);
            this.GardenInputlabel.Name = "GardenInputlabel";
            this.GardenInputlabel.Size = new System.Drawing.Size(121, 24);
            this.GardenInputlabel.TabIndex = 3;
            // 
            // ItemNumberInputlabel
            // 
            this.ItemNumberInputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemNumberInputlabel.Location = new System.Drawing.Point(175, 60);
            this.ItemNumberInputlabel.Name = "ItemNumberInputlabel";
            this.ItemNumberInputlabel.Size = new System.Drawing.Size(121, 22);
            this.ItemNumberInputlabel.TabIndex = 4;
            // 
            // QuantityInputlabel
            // 
            this.QuantityInputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityInputlabel.Location = new System.Drawing.Point(175, 91);
            this.QuantityInputlabel.Name = "QuantityInputlabel";
            this.QuantityInputlabel.Size = new System.Drawing.Size(121, 22);
            this.QuantityInputlabel.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(142, 149);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(93, 27);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FlowersCostLabel
            // 
            this.FlowersCostLabel.AutoSize = true;
            this.FlowersCostLabel.Location = new System.Drawing.Point(80, 221);
            this.FlowersCostLabel.Name = "FlowersCostLabel";
            this.FlowersCostLabel.Size = new System.Drawing.Size(87, 16);
            this.FlowersCostLabel.TabIndex = 7;
            this.FlowersCostLabel.Text = "Flowers Cost:";
            // 
            // BaseAdjustedCostLabel
            // 
            this.BaseAdjustedCostLabel.AutoSize = true;
            this.BaseAdjustedCostLabel.Location = new System.Drawing.Point(38, 255);
            this.BaseAdjustedCostLabel.Name = "BaseAdjustedCostLabel";
            this.BaseAdjustedCostLabel.Size = new System.Drawing.Size(128, 16);
            this.BaseAdjustedCostLabel.TabIndex = 8;
            this.BaseAdjustedCostLabel.Text = "Base Adjusted Cost:";
            // 
            // DiscountPercentLabel
            // 
            this.DiscountPercentLabel.AutoSize = true;
            this.DiscountPercentLabel.Location = new System.Drawing.Point(55, 282);
            this.DiscountPercentLabel.Name = "DiscountPercentLabel";
            this.DiscountPercentLabel.Size = new System.Drawing.Size(111, 16);
            this.DiscountPercentLabel.TabIndex = 9;
            this.DiscountPercentLabel.Text = "Discount Precent:";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(91, 315);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(75, 16);
            this.TotalPriceLabel.TabIndex = 10;
            this.TotalPriceLabel.Text = "Total Price:";
            // 
            // flowerCostOutput
            // 
            this.flowerCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowerCostOutput.Location = new System.Drawing.Point(173, 221);
            this.flowerCostOutput.Name = "flowerCostOutput";
            this.flowerCostOutput.Size = new System.Drawing.Size(82, 16);
            this.flowerCostOutput.TabIndex = 11;
            // 
            // baseCostOutput
            // 
            this.baseCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseCostOutput.Location = new System.Drawing.Point(172, 255);
            this.baseCostOutput.Name = "baseCostOutput";
            this.baseCostOutput.Size = new System.Drawing.Size(83, 16);
            this.baseCostOutput.TabIndex = 12;
            // 
            // discountPercentOutput
            // 
            this.discountPercentOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountPercentOutput.Location = new System.Drawing.Point(172, 282);
            this.discountPercentOutput.Name = "discountPercentOutput";
            this.discountPercentOutput.Size = new System.Drawing.Size(83, 16);
            this.discountPercentOutput.TabIndex = 13;
            // 
            // totalPriceOutput
            // 
            this.totalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutput.Location = new System.Drawing.Point(172, 315);
            this.totalPriceOutput.Name = "totalPriceOutput";
            this.totalPriceOutput.Size = new System.Drawing.Size(83, 16);
            this.totalPriceOutput.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.totalPriceOutput);
            this.Controls.Add(this.discountPercentOutput);
            this.Controls.Add(this.baseCostOutput);
            this.Controls.Add(this.flowerCostOutput);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.DiscountPercentLabel);
            this.Controls.Add(this.BaseAdjustedCostLabel);
            this.Controls.Add(this.FlowersCostLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.QuantityInputlabel);
            this.Controls.Add(this.ItemNumberInputlabel);
            this.Controls.Add(this.GardenInputlabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.GardenLabel);
            this.Name = "Form1";
            this.Text = "The Haappy Garden Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GardenLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.ComboBox GardenInputlabel;
        private System.Windows.Forms.TextBox ItemNumberInputlabel;
        private System.Windows.Forms.TextBox QuantityInputlabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label FlowersCostLabel;
        private System.Windows.Forms.Label BaseAdjustedCostLabel;
        private System.Windows.Forms.Label DiscountPercentLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label flowerCostOutput;
        private System.Windows.Forms.Label baseCostOutput;
        private System.Windows.Forms.Label discountPercentOutput;
        private System.Windows.Forms.Label totalPriceOutput;
    }
}

