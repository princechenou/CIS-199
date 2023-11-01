//GardeID R2206
//CIS 199
//Program 3
//due date 4/1/2022
//description: this will calculate the cost of the flower by the inputs that you give the system.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaring of variables
           
            double itemnumber;
            double Quantityinput;
            double validitemnmber =0 ;
            double validquantitydiscount = 0 ;
            double correctBaseRate;
            double totalflowercost = 0;
            double totalbaseadjustedcost= 0;
            double totaldiscount = 0;
            double totalcost;
            double MaxQuantity = 21;


            //declaring of arrays
            double[] flowernumber = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };
            double[] costPerFlower = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };
            double[] quantity = { 0, 6, 16, 21 };
            double[] discount = { 1, .95, .9, .85 };
            double[] baserate = { 1.1, 1, .9 };
            double[] gardenType = {0,1,2};

            if (GardenInputlabel.SelectedIndex >= 0) //if one of the garden types were selected
            {
                if (double.TryParse(ItemNumberInputlabel.Text, out itemnumber) && (itemnumber > 10000 && itemnumber < 10008)) //enter a valid number and it is between 10000 and 10008
                {
                    if (double.TryParse(QuantityInputlabel.Text, out Quantityinput) && (Quantityinput >= 0)) //to make sure you enter a valid number for the quantity box
                    {
                        for (int i = 0; i < flowernumber.Length; i++) //looks through the flowernumber array 
                        {
                            //to make the flowernumber array match with the same number in the costperflower array
                            if (itemnumber == flowernumber[i]) 
                            {
                                validitemnmber = costPerFlower[i];
                                totalflowercost = validitemnmber * Quantityinput;
                                flowerCostOutput.Text = totalflowercost.ToString("C2");

                            }

                        }
              
                        for (int i = 0; i < gardenType.Length; i++)
                        {
                            //to make sure that the gardentype array matches with the baserate arrray with the same number 
                            if (GardenInputlabel.SelectedIndex == gardenType[i])
                            {
                                correctBaseRate = baserate[i];
                                totalbaseadjustedcost = totalflowercost * baserate[i];
                                baseCostOutput.Text = totalbaseadjustedcost.ToString("c2");

                            }
                        }


                        for (int i = 0; i < quantity.Length; i++)
                        {
                            //if the quantity input is the same as quantity in array, then it has the same discount factor
                            if (Quantityinput == quantity[i])
                            {
                                validquantitydiscount = discount[i];
                                totaldiscount = 1 - validquantitydiscount;
                                discountPercentOutput.Text = totaldiscount.ToString("P2");
                                break;
                            }
                            
                            //if the quantity is in between the quantity array, then i will pick the lower number from the discount array
                            else if (Quantityinput < quantity[i])
                            {
                                validquantitydiscount = discount[i - 1];
                                totaldiscount = 1 - validquantitydiscount;
                                discountPercentOutput.Text = totaldiscount.ToString("P2");
                                break;
                            }

                            //if the quantity array is above the max quantity then it will just use the max number for the discount
                            else if (Quantityinput > MaxQuantity)
                            {
                                validquantitydiscount = discount[3];
                                totaldiscount = 1 - validquantitydiscount;
                                discountPercentOutput.Text = totaldiscount.ToString("P2");
                                break;
                            }
                        }

                        totalcost = totalbaseadjustedcost * validquantitydiscount;
                        totalPriceOutput.Text = totalcost.ToString("C2");
                    }
                    else MessageBox.Show("Please enter correct correct quantiy");

                }
                else MessageBox.Show("Please enter correct item number");
            }
            else MessageBox.Show("Please select one of the garden type");

        }
    }
}
