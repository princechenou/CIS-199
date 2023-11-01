//Lab 7
//CIS199
//GradeId: R2206
//due date: 4/10/2022
//description: prompts user to enters a valid number and then will display the number of stars for each rows.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double correctuseripnut; //declare variable
            Console.WriteLine("how many stars?"); //displays this line
            string userinput = Console.ReadLine(); //reads the user input
            bool input1 = false; 


            while (!input1)
            {
                if (double.TryParse(userinput, out correctuseripnut) && correctuseripnut > 0) //if it's a number and is greater than 0
                {
                    showMessage(correctuseripnut); //this calls the method
                    input1 = true; //this stops the code
                }
                else
                {
                    //gets the user to input another value
                    Console.WriteLine("Please enter a correct value?"); 
                    userinput = Console.ReadLine();
                    
                }
            }
        }
        private static void showMessage(double stars)
        {
            //double rows = stars;
            for (int i = 1; i <= stars; i++) //this is how many rows there are going to be, increasing by one each time
            {
                for (int e = 1; e <= stars; e++) //this is for how many stars are going to be in each row
                {
                    Console.Write("*");
                }
                Console.WriteLine(""); //this space is to break after each line of "*" is finished
            }
        }
    }
}
