using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4 : Form
    {
        //declare variables, this keeps a count for accepted and rejected
        int acceptedCount = 0;
        int rejectedCount = 0;  
        public Lab4()
        {
            InitializeComponent();
        }

        private void AdmissionDecision_Click(object sender, EventArgs e)
        {
            // declare variables 
            double GPA;
            int testScore;

            //if value for GPA is valid, then it is the variable, but if not then you must enter a valid number
            if (double.TryParse(GPATextBox.Text, out GPA))
            {
            }
           else
            {
                MessageBox.Show("Enter Valid number");
            }

            //if value for Test Score is valid, then it is the variable, but if not then you must enter a valid number
            if (int.TryParse(TestScoreTextBox.Text, out testScore))
            { }
            else
            {
               MessageBox.Show("Enter Valid number");
            }

            //if GPA is within the the range and the Test Score is within the range then you are Accepted
            if (GPA >= 3.0 && GPA <= 4.0 && testScore >= 60)
            {
                MessageBox.Show("Accepted");
                acceptedCount++; //this keeps a count of the amount of times accepted
                LoopTextbox.Text = acceptedCount.ToString(); //converts counter into string 
            }

            //if GPA is within the the range and the Test Score is within the range then you are Accepted
            else if (GPA < 3.0 && testScore >= 80)
            {
                MessageBox.Show("Accept");
                acceptedCount++; //this keeps a count of the amount of times accepted
                LoopTextbox.Text = acceptedCount.ToString(); //converts counter into string 
            }

            //if GPA is not within the range and the test score is not within the range then you are rejected
            else
            {
                MessageBox.Show("Rejected"); 
                rejectedCount++; //this keeps a count of the amount of times accepted
                totalRejectedTextbox.Text = rejectedCount.ToString(); //converts counter into string 
            }
 
                
            

        }

    }
}
