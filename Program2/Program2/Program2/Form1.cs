//Grade ID: R2206
//Class: CIS 199
//program 2
//Due Date: 3/11/2022
//description: calculate the total cost of a hotel once you fill the application with how many guests,
//the amount of nights, and the rating of the hotel





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declaring constant variables 
            const int flatRate1 = 100;
            const int flatRate2 = 150;
            const int flatRate3 = 250;
            const int flatRate4 = 400;
            const int costPerNight1 = 100;
            const int costPerNight2 = 75;
            const int costPernight3 = 25;
            const double starRate1 = 1;
            const double starRate2 = 1.5;
            const double starRate3 = 2.5;
            const double starRate4 =  3;
            const double starRate5 = 4;
            const int guestNumber1 = 1;
            const int guestNumber2 = 2;
            const int guestNumber3 = 3;
            const int guestNumber4 = 4;
            const int lowNight = 1;
            const int midNight = 6;
            const int highNight = 30;
            const int starCount1 = 1;
            const int starCount2 = 2;
            const int starCount3 = 3;
            const int starCount4 = 4;
         

            //declaring variables
            double inputGuest;
            double inputNights;
            double totalnights;
            double stars11;

            //to see if the input for number of guests, number of nights, and hotel stars is Valid
            if (double.TryParse(NumberofGuestTextBox.Text, out inputGuest) && (inputGuest > 0 && inputGuest <= 7))
            { if (double.TryParse(NumberofNightTextBox.Text, out inputNights) && (inputNights > 0))
                { if (HotelStarsComboBox.SelectedIndex >= 0)
                    {
                        if (inputGuest == guestNumber1) //if number of guests is equal to 1, then the value is 100
                        {
                            inputGuest = flatRate1;
                        }
                        else if (inputGuest == guestNumber2) //if number of guests is equal to 2, then the value is 150
                        {
                            inputGuest = flatRate2;
                        }
                        else if (inputGuest == guestNumber3) //if number of guests is equal to 3, then the value is 250
                        {
                            inputGuest = flatRate3;
                        }
                        else if (inputGuest >= guestNumber4) //if number of guests is equal to 4, then the value is 400
                        {
                            inputGuest = flatRate4;
                        }

                        if (inputNights >=lowNight && inputNights <= midNight) //if the number of nights is between 1 & 6 
                        {
                            totalnights = costPerNight1 * inputNights;
                        }
                        else if (inputNights > midNight && inputNights <= highNight) //if the number of nights is between 7 & 30 
                        {
                            totalnights = costPerNight2 * inputNights;
                        }
                        else //if the number of nights is greater than 30
                        {
                            totalnights = costPernight3 * inputNights;
                        }
                        
                        
                        //convert the select box to a number 
                        int StarInput = int.Parse(HotelStarsComboBox.SelectedItem.ToString());
                        if (StarInput == starCount1) //if number equals 1 then it is 1x
                        {
                            stars11 = starRate1;
                        }
                        else if (StarInput == starCount2) //if number equals 2 then it is 1.5x
                        {
                            stars11 = starRate2;
                        }
                        else if (StarInput == starCount3) //if number equals 3 then it is 2.5x
                        {
                            stars11 = starRate3;
                        }
                        else if (StarInput == starCount4) //if number equals 4 then it is 3x
                        {
                            stars11 = starRate4;
                        }
                        else //if number equals 5 then it is 4x
                        {
                            stars11 = starRate5;
                        }

                        //equations to find the total cost
                        double totalinput = totalnights + inputGuest; 
                        double totalcost1 = Convert.ToDouble(totalinput) * stars11;
                        HotelCostTextbox.Text = totalcost1.ToString("c2"); //show the answer as currency

                    }
                    else MessageBox.Show("select number of stars:"); //displays error message
                }
                else MessageBox.Show("enter valid number of nights"); //displays error message

            }

            else MessageBox.Show("enter valid number of guests"); //displays error message
        }
    }
}
    