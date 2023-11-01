//Grade ID: R2206
// Lab 6
//course: CIS 199
// due date: 3/7/2022
//despriction: pastes out differernt patterns of "*"


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("PATTERN A"); // this writes out pattern A
            Console.WriteLine("");
            const int MAX_ROWS = 10; // declare variable, max rows

            for (int row = 1; row <= MAX_ROWS; row++) //this is how many rows there are going to be, increasing by one each time
            {
                for (int star = 1; star <= row; star++) //how many stars are going to be in each row
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine("PATTERN B"); //writes out pattern B
            Console.WriteLine("");

            const int MAX_TILE = 1;

            for (int row = 10; row >= MAX_TILE; row--) //how many rows there are going to be in decreaasing order 
            {
                for (int star = 1; star <= row; star++) //how many starts are going to be in each row
                    Console.Write("*"); //displays the stars
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine("PATTERN C"); //Writes out pattern C
            Console.WriteLine("");

            for (int row = 10; row >= MAX_TILE; row--) //how many rows are going to have, how many stars allowed per row, decreasing by one 
            {
                int temp = 10 - row; //how many spaces 
                for(int space = 1; space <= temp; space++) //counts the amount of spaces 
                    Console.Write(" ");
                for (int star = 1; star <= row; star++) //how many starts are going to be in each row
                    Console.Write("*"); //displays the stars
                Console.WriteLine();

            }

            Console.WriteLine("");
            Console.WriteLine("PATTERN D"); //writes out pattern B
            Console.WriteLine("");
            

            for (int row = 1; row <= MAX_ROWS; row++) //row increase my one until it gets to 10
            {

                int temp = 10 - row; // how many spaces is available 
                for (int space = 1; space <= temp; space++) //displays the amount of spaces
                    Console.Write(" ");
                for (int star = 1; star <= row; star++) //how many stars is available for each row
                    Console.Write("*"); //displys the "*"
                Console.WriteLine();

            }
        }

    }
}
