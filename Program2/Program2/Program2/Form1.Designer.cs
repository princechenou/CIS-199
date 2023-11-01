namespace Program2
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
            this.label1 = new System.Windows.Forms.Label();
            this.hotelSignslabel = new System.Windows.Forms.Label();
            this.numberOfGuestLabel = new System.Windows.Forms.Label();
            this.numberofLightsLabel = new System.Windows.Forms.Label();
            this.hotelCostLabel = new System.Windows.Forms.Label();
            this.NumberofNightTextBox = new System.Windows.Forms.TextBox();
            this.NumberofGuestTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HotelStarsComboBox = new System.Windows.Forms.ComboBox();
            this.HotelCostTextbox = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // hotelSignslabel
            // 
            this.hotelSignslabel.AutoSize = true;
            this.hotelSignslabel.Location = new System.Drawing.Point(208, 128);
            this.hotelSignslabel.Name = "hotelSignslabel";
            this.hotelSignslabel.Size = new System.Drawing.Size(76, 16);
            this.hotelSignslabel.TabIndex = 1;
            this.hotelSignslabel.Text = "Hotel Stars:";
            // 
            // numberOfGuestLabel
            // 
            this.numberOfGuestLabel.AutoSize = true;
            this.numberOfGuestLabel.Location = new System.Drawing.Point(174, 22);
            this.numberOfGuestLabel.Name = "numberOfGuestLabel";
            this.numberOfGuestLabel.Size = new System.Drawing.Size(117, 16);
            this.numberOfGuestLabel.TabIndex = 2;
            this.numberOfGuestLabel.Text = "Number of Guests:";
            // 
            // numberofLightsLabel
            // 
            this.numberofLightsLabel.AutoSize = true;
            this.numberofLightsLabel.Location = new System.Drawing.Point(174, 73);
            this.numberofLightsLabel.Name = "numberofLightsLabel";
            this.numberofLightsLabel.Size = new System.Drawing.Size(113, 16);
            this.numberofLightsLabel.TabIndex = 3;
            this.numberofLightsLabel.Text = "Number of Nights:";
            // 
            // hotelCostLabel
            // 
            this.hotelCostLabel.AutoSize = true;
            this.hotelCostLabel.Location = new System.Drawing.Point(208, 224);
            this.hotelCostLabel.Name = "hotelCostLabel";
            this.hotelCostLabel.Size = new System.Drawing.Size(72, 16);
            this.hotelCostLabel.TabIndex = 4;
            this.hotelCostLabel.Text = "Hotel Cost:";
            // 
            // NumberofNightTextBox
            // 
            this.NumberofNightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberofNightTextBox.Location = new System.Drawing.Point(330, 67);
            this.NumberofNightTextBox.Name = "NumberofNightTextBox";
            this.NumberofNightTextBox.Size = new System.Drawing.Size(121, 22);
            this.NumberofNightTextBox.TabIndex = 5;
            // 
            // NumberofGuestTextBox
            // 
            this.NumberofGuestTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberofGuestTextBox.Location = new System.Drawing.Point(330, 16);
            this.NumberofGuestTextBox.Name = "NumberofGuestTextBox";
            this.NumberofGuestTextBox.Size = new System.Drawing.Size(121, 22);
            this.NumberofGuestTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // HotelStarsComboBox
            // 
            this.HotelStarsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HotelStarsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HotelStarsComboBox.FormattingEnabled = true;
            this.HotelStarsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.HotelStarsComboBox.Location = new System.Drawing.Point(330, 120);
            this.HotelStarsComboBox.Name = "HotelStarsComboBox";
            this.HotelStarsComboBox.Size = new System.Drawing.Size(121, 24);
            this.HotelStarsComboBox.TabIndex = 8;
            // 
            // HotelCostTextbox
            // 
            this.HotelCostTextbox.Location = new System.Drawing.Point(330, 224);
            this.HotelCostTextbox.Name = "HotelCostTextbox";
            this.HotelCostTextbox.Size = new System.Drawing.Size(121, 23);
            this.HotelCostTextbox.TabIndex = 9;
            // 
            // CalculateButton
            // 
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.Location = new System.Drawing.Point(284, 171);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(97, 26);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.HotelCostTextbox);
            this.Controls.Add(this.HotelStarsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberofGuestTextBox);
            this.Controls.Add(this.NumberofNightTextBox);
            this.Controls.Add(this.hotelCostLabel);
            this.Controls.Add(this.numberofLightsLabel);
            this.Controls.Add(this.numberOfGuestLabel);
            this.Controls.Add(this.hotelSignslabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hotelSignslabel;
        private System.Windows.Forms.Label numberOfGuestLabel;
        private System.Windows.Forms.Label numberofLightsLabel;
        private System.Windows.Forms.Label hotelCostLabel;
        private System.Windows.Forms.TextBox NumberofNightTextBox;
        private System.Windows.Forms.TextBox NumberofGuestTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox HotelStarsComboBox;
        private System.Windows.Forms.Label HotelCostTextbox;
        private System.Windows.Forms.Button CalculateButton;
    }
}

