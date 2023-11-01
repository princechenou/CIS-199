//Grade ID: R2206
//CIS 199-02
//Lab 3
//Due Date: 2/13/2022
//description: input the radius and you will get the diameter, surface value, and volume

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e) //once you click the "calculate" or the enter button
        {
            double inputvalue; //input value is declared
            double diameterRatio = 2; // declaring the diameter
            double SurfaceArea = 4 * Math.PI; //declaring the surface area formula
            double volume = (4 * Math.PI) / 3; //declating the volume formula

            double TotalDiameter; //declaring total diameter
            double TotalSurfaceArea; //declaring total surface area
            double TotalVolume; //declaring total volume

            inputvalue = double.Parse(RadiusInputTextbox.Text); //changing the input from string to double
            TotalDiameter = (inputvalue * diameterRatio); //diameter is equal to the number inputed and the ratio
            DiameterTextbox.Text = TotalDiameter.ToString("F2"); //convert back to the text with 2 decimals
            TotalSurfaceArea = SurfaceArea * Math.Pow(inputvalue, 2); //surface area is equal to the ratio times input value
            SurfaceAreaTextbox.Text = TotalSurfaceArea.ToString("F2"); //convert answer to the textbox with two decimals
            TotalVolume = volume * Math.Pow(inputvalue, 3); //total volume is equal to the volume ratio times the input value
            VolumeTextbox.Text = TotalVolume.ToString("F2");//answer is convert back in to the textbox format

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadiusInput_Click(object sender, EventArgs e)
        {

        }
    }
}
