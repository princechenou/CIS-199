// Grade ID R2206
// Lab 2
//course section : CIs 199-02
// due date : 2/6/2022
// Description : this code is going to give you the tip percentage of 15%, 18%, 20% once you put in a given number

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OutputButton_Click(object sender, EventArgs e) //once you hit the "calculate tip" button, this is what happens
        {

            double num1; //declare a number
            double TipRate1 = .15; // declare the first rate
            double TipRate2 = .18; // declare the second rate
            double TipRate3 = .20; //declare the last rate
            num1 = double.Parse(InputPrice.Text); //num is equal to the number put in the text box
            rate1LabelBox.Text = (num1 * TipRate1).ToString("c"); //multiple number by .15 then convert to string with Currency format
            rate2LabelBox.Text = (num1 * TipRate2).ToString("C"); //multiple number by .18 then convert to string with currency format
            rate3LabelBox.Text = (num1 * TipRate3).ToString("c"); //multiple numb by .2 then convert to string with currency form


        }
    }
}
