//Grade ID: R2206
//Program 1
//dude date: 2/14/2022
//description: input variables to find the total cost to build.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void TotalCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //what will happen once you click the button
        {
            const double Extrapercent = 1.1; //declare variable for the percent
            

            //declare variables
            double lenghtfront;
            double lenghtside;
            double height;
            double Totalside;
            double TotalFront;
            double TotalLenght;
            int windowcost;
            int TotalWindowCost;
            double TotalSqaureFeet;
            double TotalSqfWithPercent;
            double TotalLaborCost;
            double laborcost;
            double materialcost;
            double Totalmaterialcost;
            double totalcost;

            //getting the information to from input & calculate the total side, front, and lenght
            lenghtfront = double.Parse(LenghtofFrontText.Text);
            lenghtside = double.Parse(LenghtofSideText.Text);
            height = double.Parse(HeightText.Text);
            Totalside = (lenghtside * height) * 2;
            TotalFront = (lenghtfront * height) * 2;
            TotalLenght = lenghtside * lenghtfront;

            //fucntion for either the 1 window or 0 window
            windowcost = int.Parse(WindowCosttext.Text);
            if (windowcost == 1)
                TotalWindowCost = 100;
            else TotalWindowCost = 0;

            //formula for the total square feet, and also displaying it back
            TotalSqaureFeet = Totalside + TotalLenght + TotalFront;
            TotalSQText.Text = TotalSqaureFeet.ToString("f2");
            
            //formula for the total square feet with the 10% extra & displaying it
            TotalSqfWithPercent = TotalSqaureFeet * Extrapercent;
            Extra10Text.Text = TotalSqfWithPercent.ToString("f2");

            //getting information on the labor cost & creatinga  formula to display the total labor cost 
            laborcost = double.Parse(CostofLaborText.Text);
            TotalLaborCost = laborcost * TotalSqfWithPercent;
            LaborCostText.Text = TotalLaborCost.ToString("c2");

            //getting the information about the material coust & creating a formula to display the total material cost
            materialcost = double.Parse(CostofWallText.Text);
            Totalmaterialcost = materialcost * TotalSqfWithPercent;
            MaterialCostText.Text = Totalmaterialcost.ToString("c2");

            // formula for the total cost & displaying it back to the form
            totalcost = Totalmaterialcost + TotalLaborCost + TotalWindowCost;
            TotalCostText.Text = totalcost.ToString("c2");



        









        }

        private void LenghtofFrontText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
