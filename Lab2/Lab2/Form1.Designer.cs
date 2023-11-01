namespace Lab2
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
            this.MealPrice = new System.Windows.Forms.Label();
            this.TipRate1st = new System.Windows.Forms.Label();
            this.TipRate2nd = new System.Windows.Forms.Label();
            this.TipRate3rd = new System.Windows.Forms.Label();
            this.rate3LabelBox = new System.Windows.Forms.Label();
            this.rate2LabelBox = new System.Windows.Forms.Label();
            this.rate1LabelBox = new System.Windows.Forms.Label();
            this.InputPrice = new System.Windows.Forms.TextBox();
            this.OutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MealPrice
            // 
            this.MealPrice.AutoSize = true;
            this.MealPrice.Location = new System.Drawing.Point(148, 34);
            this.MealPrice.Name = "MealPrice";
            this.MealPrice.Size = new System.Drawing.Size(122, 16);
            this.MealPrice.TabIndex = 0;
            this.MealPrice.Text = "Enter Price of Meal:";
            // 
            // TipRate1st
            // 
            this.TipRate1st.AutoSize = true;
            this.TipRate1st.Location = new System.Drawing.Point(219, 72);
            this.TipRate1st.Name = "TipRate1st";
            this.TipRate1st.Size = new System.Drawing.Size(33, 16);
            this.TipRate1st.TabIndex = 1;
            this.TipRate1st.Text = "15%";
            // 
            // TipRate2nd
            // 
            this.TipRate2nd.AutoSize = true;
            this.TipRate2nd.Location = new System.Drawing.Point(219, 109);
            this.TipRate2nd.Name = "TipRate2nd";
            this.TipRate2nd.Size = new System.Drawing.Size(33, 16);
            this.TipRate2nd.TabIndex = 2;
            this.TipRate2nd.Text = "18%";
            // 
            // TipRate3rd
            // 
            this.TipRate3rd.AutoSize = true;
            this.TipRate3rd.Location = new System.Drawing.Point(219, 143);
            this.TipRate3rd.Name = "TipRate3rd";
            this.TipRate3rd.Size = new System.Drawing.Size(33, 16);
            this.TipRate3rd.TabIndex = 3;
            this.TipRate3rd.Text = "20%";
            // 
            // rate3LabelBox
            // 
            this.rate3LabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rate3LabelBox.Location = new System.Drawing.Point(285, 136);
            this.rate3LabelBox.Name = "rate3LabelBox";
            this.rate3LabelBox.Size = new System.Drawing.Size(100, 23);
            this.rate3LabelBox.TabIndex = 4;
            // 
            // rate2LabelBox
            // 
            this.rate2LabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rate2LabelBox.Location = new System.Drawing.Point(285, 102);
            this.rate2LabelBox.Name = "rate2LabelBox";
            this.rate2LabelBox.Size = new System.Drawing.Size(100, 23);
            this.rate2LabelBox.TabIndex = 5;
            // 
            // rate1LabelBox
            // 
            this.rate1LabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rate1LabelBox.Location = new System.Drawing.Point(285, 65);
            this.rate1LabelBox.Name = "rate1LabelBox";
            this.rate1LabelBox.Size = new System.Drawing.Size(100, 23);
            this.rate1LabelBox.TabIndex = 6;
            // 
            // InputPrice
            // 
            this.InputPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPrice.Location = new System.Drawing.Point(285, 28);
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.Size = new System.Drawing.Size(100, 22);
            this.InputPrice.TabIndex = 7;
            // 
            // OutputButton
            // 
            this.OutputButton.AutoSize = true;
            this.OutputButton.Location = new System.Drawing.Point(222, 171);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(96, 26);
            this.OutputButton.TabIndex = 8;
            this.OutputButton.Text = "Calculate Tip";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.InputPrice);
            this.Controls.Add(this.rate1LabelBox);
            this.Controls.Add(this.rate2LabelBox);
            this.Controls.Add(this.rate3LabelBox);
            this.Controls.Add(this.TipRate3rd);
            this.Controls.Add(this.TipRate2nd);
            this.Controls.Add(this.TipRate1st);
            this.Controls.Add(this.MealPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MealPrice;
        private System.Windows.Forms.Label TipRate1st;
        private System.Windows.Forms.Label TipRate2nd;
        private System.Windows.Forms.Label TipRate3rd;
        private System.Windows.Forms.Label rate3LabelBox;
        private System.Windows.Forms.Label rate2LabelBox;
        private System.Windows.Forms.Label rate1LabelBox;
        private System.Windows.Forms.TextBox InputPrice;
        private System.Windows.Forms.Button OutputButton;
    }
}

