namespace Program1
{
    partial class Program1
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
            this.FormTitle = new System.Windows.Forms.Label();
            this.LenghtTitle = new System.Windows.Forms.Label();
            this.LenghtSideLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WindowLabel = new System.Windows.Forms.Label();
            this.CostWallLabel = new System.Windows.Forms.Label();
            this.CostofLaborLabel = new System.Windows.Forms.Label();
            this.SQFootLabel = new System.Windows.Forms.Label();
            this.TenPercentLabel = new System.Windows.Forms.Label();
            this.LaborCostLabel = new System.Windows.Forms.Label();
            this.MaterialCostLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TotalSQText = new System.Windows.Forms.Label();
            this.Extra10Text = new System.Windows.Forms.Label();
            this.LaborCostText = new System.Windows.Forms.Label();
            this.MaterialCostText = new System.Windows.Forms.Label();
            this.TotalCostText = new System.Windows.Forms.Label();
            this.LenghtofFrontText = new System.Windows.Forms.TextBox();
            this.LenghtofSideText = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WindowCosttext = new System.Windows.Forms.TextBox();
            this.CostofWallText = new System.Windows.Forms.TextBox();
            this.CostofLaborText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Location = new System.Drawing.Point(99, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(228, 16);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Dry Wall and Window Cost Calculator";
            // 
            // LenghtTitle
            // 
            this.LenghtTitle.AutoSize = true;
            this.LenghtTitle.Location = new System.Drawing.Point(119, 54);
            this.LenghtTitle.Name = "LenghtTitle";
            this.LenghtTitle.Size = new System.Drawing.Size(114, 16);
            this.LenghtTitle.TabIndex = 1;
            this.LenghtTitle.Text = "Lenght of Front (ft):";
            // 
            // LenghtSideLabel
            // 
            this.LenghtSideLabel.AutoSize = true;
            this.LenghtSideLabel.Location = new System.Drawing.Point(121, 85);
            this.LenghtSideLabel.Name = "LenghtSideLabel";
            this.LenghtSideLabel.Size = new System.Drawing.Size(112, 16);
            this.LenghtSideLabel.TabIndex = 2;
            this.LenghtSideLabel.Text = "Lenght of Side (ft):";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(167, 112);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(66, 16);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "Height (ft):";
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Location = new System.Drawing.Point(67, 168);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(166, 16);
            this.WindowLabel.TabIndex = 4;
            this.WindowLabel.Text = "Window? (1 = YES, 0 = NO)";
            // 
            // CostWallLabel
            // 
            this.CostWallLabel.AutoSize = true;
            this.CostWallLabel.Location = new System.Drawing.Point(57, 225);
            this.CostWallLabel.Name = "CostWallLabel";
            this.CostWallLabel.Size = new System.Drawing.Size(181, 16);
            this.CostWallLabel.TabIndex = 5;
            this.CostWallLabel.Text = "Cost of Dry Wall Per SQ Feet:";
            // 
            // CostofLaborLabel
            // 
            this.CostofLaborLabel.AutoSize = true;
            this.CostofLaborLabel.Location = new System.Drawing.Point(72, 256);
            this.CostofLaborLabel.Name = "CostofLaborLabel";
            this.CostofLaborLabel.Size = new System.Drawing.Size(165, 16);
            this.CostofLaborLabel.TabIndex = 6;
            this.CostofLaborLabel.Text = "Cost of Labor Per SQ Feet:";
            // 
            // SQFootLabel
            // 
            this.SQFootLabel.AutoSize = true;
            this.SQFootLabel.Location = new System.Drawing.Point(95, 291);
            this.SQFootLabel.Name = "SQFootLabel";
            this.SQFootLabel.Size = new System.Drawing.Size(138, 16);
            this.SQFootLabel.TabIndex = 7;
            this.SQFootLabel.Text = "Total SQ feet needed:";
            // 
            // TenPercentLabel
            // 
            this.TenPercentLabel.AutoSize = true;
            this.TenPercentLabel.Location = new System.Drawing.Point(164, 318);
            this.TenPercentLabel.Name = "TenPercentLabel";
            this.TenPercentLabel.Size = new System.Drawing.Size(69, 16);
            this.TenPercentLabel.TabIndex = 8;
            this.TenPercentLabel.Text = "10% Extra:";
            // 
            // LaborCostLabel
            // 
            this.LaborCostLabel.AutoSize = true;
            this.LaborCostLabel.Location = new System.Drawing.Point(158, 348);
            this.LaborCostLabel.Name = "LaborCostLabel";
            this.LaborCostLabel.Size = new System.Drawing.Size(75, 16);
            this.LaborCostLabel.TabIndex = 9;
            this.LaborCostLabel.Text = "Labor Cost:";
            // 
            // MaterialCostLabel
            // 
            this.MaterialCostLabel.AutoSize = true;
            this.MaterialCostLabel.Location = new System.Drawing.Point(145, 378);
            this.MaterialCostLabel.Name = "MaterialCostLabel";
            this.MaterialCostLabel.Size = new System.Drawing.Size(88, 16);
            this.MaterialCostLabel.TabIndex = 10;
            this.MaterialCostLabel.Text = "Material Cost:";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(158, 404);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(82, 16);
            this.TotalCostLabel.TabIndex = 11;
            this.TotalCostLabel.Text = "Total Cost:";
            this.TotalCostLabel.Click += new System.EventHandler(this.TotalCostLabel_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.Location = new System.Drawing.Point(175, 447);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(143, 26);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Caluclate Estimate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalSQText
            // 
            this.TotalSQText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalSQText.Location = new System.Drawing.Point(252, 286);
            this.TotalSQText.Name = "TotalSQText";
            this.TotalSQText.Size = new System.Drawing.Size(124, 21);
            this.TotalSQText.TabIndex = 15;
            // 
            // Extra10Text
            // 
            this.Extra10Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Extra10Text.Location = new System.Drawing.Point(252, 314);
            this.Extra10Text.Name = "Extra10Text";
            this.Extra10Text.Size = new System.Drawing.Size(124, 20);
            this.Extra10Text.TabIndex = 16;
            // 
            // LaborCostText
            // 
            this.LaborCostText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaborCostText.Location = new System.Drawing.Point(252, 344);
            this.LaborCostText.Name = "LaborCostText";
            this.LaborCostText.Size = new System.Drawing.Size(124, 20);
            this.LaborCostText.TabIndex = 17;
            // 
            // MaterialCostText
            // 
            this.MaterialCostText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaterialCostText.Location = new System.Drawing.Point(252, 372);
            this.MaterialCostText.Name = "MaterialCostText";
            this.MaterialCostText.Size = new System.Drawing.Size(124, 22);
            this.MaterialCostText.TabIndex = 18;
            // 
            // TotalCostText
            // 
            this.TotalCostText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostText.Location = new System.Drawing.Point(252, 404);
            this.TotalCostText.Name = "TotalCostText";
            this.TotalCostText.Size = new System.Drawing.Size(124, 20);
            this.TotalCostText.TabIndex = 19;
            // 
            // LenghtofFrontText
            // 
            this.LenghtofFrontText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LenghtofFrontText.Location = new System.Drawing.Point(252, 48);
            this.LenghtofFrontText.Name = "LenghtofFrontText";
            this.LenghtofFrontText.Size = new System.Drawing.Size(124, 22);
            this.LenghtofFrontText.TabIndex = 20;
            this.LenghtofFrontText.TextChanged += new System.EventHandler(this.LenghtofFrontText_TextChanged);
            // 
            // LenghtofSideText
            // 
            this.LenghtofSideText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LenghtofSideText.Location = new System.Drawing.Point(252, 83);
            this.LenghtofSideText.Name = "LenghtofSideText";
            this.LenghtofSideText.Size = new System.Drawing.Size(124, 22);
            this.LenghtofSideText.TabIndex = 21;
            // 
            // HeightText
            // 
            this.HeightText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightText.Location = new System.Drawing.Point(252, 110);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(124, 22);
            this.HeightText.TabIndex = 22;
            // 
            // WindowCosttext
            // 
            this.WindowCosttext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowCosttext.Location = new System.Drawing.Point(252, 162);
            this.WindowCosttext.Name = "WindowCosttext";
            this.WindowCosttext.Size = new System.Drawing.Size(124, 22);
            this.WindowCosttext.TabIndex = 23;
            // 
            // CostofWallText
            // 
            this.CostofWallText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostofWallText.Location = new System.Drawing.Point(252, 219);
            this.CostofWallText.Name = "CostofWallText";
            this.CostofWallText.Size = new System.Drawing.Size(124, 22);
            this.CostofWallText.TabIndex = 24;
            // 
            // CostofLaborText
            // 
            this.CostofLaborText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostofLaborText.Location = new System.Drawing.Point(252, 256);
            this.CostofLaborText.Name = "CostofLaborText";
            this.CostofLaborText.Size = new System.Drawing.Size(124, 22);
            this.CostofLaborText.TabIndex = 25;
            // 
            // Program1
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 499);
            this.Controls.Add(this.CostofLaborText);
            this.Controls.Add(this.CostofWallText);
            this.Controls.Add(this.WindowCosttext);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.LenghtofSideText);
            this.Controls.Add(this.LenghtofFrontText);
            this.Controls.Add(this.TotalCostText);
            this.Controls.Add(this.MaterialCostText);
            this.Controls.Add(this.LaborCostText);
            this.Controls.Add(this.Extra10Text);
            this.Controls.Add(this.TotalSQText);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.MaterialCostLabel);
            this.Controls.Add(this.LaborCostLabel);
            this.Controls.Add(this.TenPercentLabel);
            this.Controls.Add(this.SQFootLabel);
            this.Controls.Add(this.CostofLaborLabel);
            this.Controls.Add(this.CostWallLabel);
            this.Controls.Add(this.WindowLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.LenghtSideLabel);
            this.Controls.Add(this.LenghtTitle);
            this.Controls.Add(this.FormTitle);
            this.Name = "Program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label LenghtTitle;
        private System.Windows.Forms.Label LenghtSideLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.Label CostWallLabel;
        private System.Windows.Forms.Label CostofLaborLabel;
        private System.Windows.Forms.Label SQFootLabel;
        private System.Windows.Forms.Label TenPercentLabel;
        private System.Windows.Forms.Label LaborCostLabel;
        private System.Windows.Forms.Label MaterialCostLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label TotalSQText;
        private System.Windows.Forms.Label Extra10Text;
        private System.Windows.Forms.Label LaborCostText;
        private System.Windows.Forms.Label MaterialCostText;
        private System.Windows.Forms.Label TotalCostText;
        private System.Windows.Forms.TextBox LenghtofFrontText;
        private System.Windows.Forms.TextBox LenghtofSideText;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.TextBox WindowCosttext;
        private System.Windows.Forms.TextBox CostofWallText;
        private System.Windows.Forms.TextBox CostofLaborText;
    }
}

