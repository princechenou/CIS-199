namespace Lab4
{
    partial class Lab4
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
            this.GPALAbel = new System.Windows.Forms.Label();
            this.TestLabel = new System.Windows.Forms.Label();
            this.GPATextBox = new System.Windows.Forms.TextBox();
            this.TestScoreTextBox = new System.Windows.Forms.TextBox();
            this.AdmissionDecision = new System.Windows.Forms.Button();
            this.TotalAcceptedLabel = new System.Windows.Forms.Label();
            this.LoopTextbox = new System.Windows.Forms.Label();
            this.totalRejectedLabel = new System.Windows.Forms.Label();
            this.totalRejectedTextbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GPALAbel
            // 
            this.GPALAbel.AutoSize = true;
            this.GPALAbel.Location = new System.Drawing.Point(55, 49);
            this.GPALAbel.Name = "GPALAbel";
            this.GPALAbel.Size = new System.Drawing.Size(72, 16);
            this.GPALAbel.TabIndex = 0;
            this.GPALAbel.Text = "Enter GPA:";
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(17, 87);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(110, 16);
            this.TestLabel.TabIndex = 1;
            this.TestLabel.Text = "Enter Test Score:";
            // 
            // GPATextBox
            // 
            this.GPATextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPATextBox.Location = new System.Drawing.Point(144, 46);
            this.GPATextBox.Name = "GPATextBox";
            this.GPATextBox.Size = new System.Drawing.Size(100, 22);
            this.GPATextBox.TabIndex = 2;
            // 
            // TestScoreTextBox
            // 
            this.TestScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestScoreTextBox.Location = new System.Drawing.Point(144, 81);
            this.TestScoreTextBox.Name = "TestScoreTextBox";
            this.TestScoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.TestScoreTextBox.TabIndex = 3;
            // 
            // AdmissionDecision
            // 
            this.AdmissionDecision.AutoSize = true;
            this.AdmissionDecision.Location = new System.Drawing.Point(95, 142);
            this.AdmissionDecision.Name = "AdmissionDecision";
            this.AdmissionDecision.Size = new System.Drawing.Size(136, 26);
            this.AdmissionDecision.TabIndex = 4;
            this.AdmissionDecision.Text = "Admission Decision";
            this.AdmissionDecision.UseVisualStyleBackColor = true;
            this.AdmissionDecision.Click += new System.EventHandler(this.AdmissionDecision_Click);
            // 
            // TotalAcceptedLabel
            // 
            this.TotalAcceptedLabel.AutoSize = true;
            this.TotalAcceptedLabel.Location = new System.Drawing.Point(55, 207);
            this.TotalAcceptedLabel.Name = "TotalAcceptedLabel";
            this.TotalAcceptedLabel.Size = new System.Drawing.Size(99, 16);
            this.TotalAcceptedLabel.TabIndex = 5;
            this.TotalAcceptedLabel.Text = "Total Accepted";
            // 
            // LoopTextbox
            // 
            this.LoopTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoopTextbox.Location = new System.Drawing.Point(169, 200);
            this.LoopTextbox.Name = "LoopTextbox";
            this.LoopTextbox.Size = new System.Drawing.Size(75, 23);
            this.LoopTextbox.TabIndex = 6;
            // 
            // totalRejectedLabel
            // 
            this.totalRejectedLabel.AutoSize = true;
            this.totalRejectedLabel.Location = new System.Drawing.Point(55, 250);
            this.totalRejectedLabel.Name = "totalRejectedLabel";
            this.totalRejectedLabel.Size = new System.Drawing.Size(96, 16);
            this.totalRejectedLabel.TabIndex = 8;
            this.totalRejectedLabel.Text = "Total Rejected";
            // 
            // totalRejectedTextbox
            // 
            this.totalRejectedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRejectedTextbox.Location = new System.Drawing.Point(169, 243);
            this.totalRejectedTextbox.Name = "totalRejectedTextbox";
            this.totalRejectedTextbox.Size = new System.Drawing.Size(75, 23);
            this.totalRejectedTextbox.TabIndex = 9;
            // 
            // Lab4
            // 
            this.AcceptButton = this.AdmissionDecision;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.totalRejectedTextbox);
            this.Controls.Add(this.totalRejectedLabel);
            this.Controls.Add(this.LoopTextbox);
            this.Controls.Add(this.TotalAcceptedLabel);
            this.Controls.Add(this.AdmissionDecision);
            this.Controls.Add(this.TestScoreTextBox);
            this.Controls.Add(this.GPATextBox);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.GPALAbel);
            this.Name = "Lab4";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GPALAbel;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.TextBox GPATextBox;
        private System.Windows.Forms.TextBox TestScoreTextBox;
        private System.Windows.Forms.Button AdmissionDecision;
        private System.Windows.Forms.Label TotalAcceptedLabel;
        private System.Windows.Forms.Label LoopTextbox;
        private System.Windows.Forms.Label totalRejectedLabel;
        private System.Windows.Forms.Label totalRejectedTextbox;
    }
}

