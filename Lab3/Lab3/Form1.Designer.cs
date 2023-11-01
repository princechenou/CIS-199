namespace Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RadiusInput = new System.Windows.Forms.Label();
            this.RadiusInputTextbox = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.Diameter = new System.Windows.Forms.Label();
            this.SurfaceArea = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.DiameterTextbox = new System.Windows.Forms.Label();
            this.SurfaceAreaTextbox = new System.Windows.Forms.Label();
            this.VolumeTextbox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RadiusInput
            // 
            this.RadiusInput.AutoSize = true;
            this.RadiusInput.Location = new System.Drawing.Point(151, 25);
            this.RadiusInput.Name = "RadiusInput";
            this.RadiusInput.Size = new System.Drawing.Size(112, 16);
            this.RadiusInput.TabIndex = 0;
            this.RadiusInput.Text = "Radius of sphere:";
            this.RadiusInput.Click += new System.EventHandler(this.RadiusInput_Click);
            // 
            // RadiusInputTextbox
            // 
            this.RadiusInputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RadiusInputTextbox.Location = new System.Drawing.Point(269, 23);
            this.RadiusInputTextbox.Name = "RadiusInputTextbox";
            this.RadiusInputTextbox.Size = new System.Drawing.Size(100, 22);
            this.RadiusInputTextbox.TabIndex = 1;
            // 
            // InputButton
            // 
            this.InputButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.InputButton.AutoSize = true;
            this.InputButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.InputButton.Location = new System.Drawing.Point(283, 51);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 26);
            this.InputButton.TabIndex = 2;
            this.InputButton.Text = "Calculate";
            this.InputButton.UseVisualStyleBackColor = false;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // Diameter
            // 
            this.Diameter.AutoSize = true;
            this.Diameter.Location = new System.Drawing.Point(25, 226);
            this.Diameter.Name = "Diameter";
            this.Diameter.Size = new System.Drawing.Size(62, 16);
            this.Diameter.TabIndex = 3;
            this.Diameter.Text = "Diamater";
            // 
            // SurfaceArea
            // 
            this.SurfaceArea.AutoSize = true;
            this.SurfaceArea.Location = new System.Drawing.Point(2, 270);
            this.SurfaceArea.Name = "SurfaceArea";
            this.SurfaceArea.Size = new System.Drawing.Size(85, 16);
            this.SurfaceArea.TabIndex = 4;
            this.SurfaceArea.Text = "Surface Area";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(34, 303);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(53, 16);
            this.VolumeLabel.TabIndex = 5;
            this.VolumeLabel.Text = "Volume";
            // 
            // DiameterTextbox
            // 
            this.DiameterTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiameterTextbox.Location = new System.Drawing.Point(111, 219);
            this.DiameterTextbox.Name = "DiameterTextbox";
            this.DiameterTextbox.Size = new System.Drawing.Size(100, 23);
            this.DiameterTextbox.TabIndex = 6;
            // 
            // SurfaceAreaTextbox
            // 
            this.SurfaceAreaTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurfaceAreaTextbox.Location = new System.Drawing.Point(111, 263);
            this.SurfaceAreaTextbox.Name = "SurfaceAreaTextbox";
            this.SurfaceAreaTextbox.Size = new System.Drawing.Size(100, 23);
            this.SurfaceAreaTextbox.TabIndex = 7;
            // 
            // VolumeTextbox
            // 
            this.VolumeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VolumeTextbox.Location = new System.Drawing.Point(111, 302);
            this.VolumeTextbox.Name = "VolumeTextbox";
            this.VolumeTextbox.Size = new System.Drawing.Size(100, 23);
            this.VolumeTextbox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.InputButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VolumeTextbox);
            this.Controls.Add(this.SurfaceAreaTextbox);
            this.Controls.Add(this.DiameterTextbox);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.SurfaceArea);
            this.Controls.Add(this.Diameter);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.RadiusInputTextbox);
            this.Controls.Add(this.RadiusInput);
            this.Name = "Form1";
            this.Text = "Lab3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RadiusInput;
        private System.Windows.Forms.TextBox RadiusInputTextbox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Label Diameter;
        private System.Windows.Forms.Label SurfaceArea;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label DiameterTextbox;
        private System.Windows.Forms.Label SurfaceAreaTextbox;
        private System.Windows.Forms.Label VolumeTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

