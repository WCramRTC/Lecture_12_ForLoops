using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12_ForLoops
{
    internal class Program
    {

        static void Main(string[] args)
        {
            PrintStars();
            // **********
            // **********
            // **********
            // **********

            // This stops my app from closing
            Console.ReadKey();
        } // Main

        public static void PrintStars()
        {
            Console.WriteLine("How many rows: ");
            int num = int.Parse(Console.ReadLine());
            bool changeColor = true;
            Random rand = new Random();
            for (int i = 0; i < num; i++)
            {
                if (rand.Next(2) == 0) Console.ForegroundColor = ConsoleColor.Red;
                else Console.ForegroundColor = ConsoleColor.Green;

                for (int j = 0; j < num; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                changeColor = !changeColor;
                Console.WriteLine();
            }
        } // 

        public static void ShapeExample()
        {
            // inclusive
            // exclusive
            int count = 10;
            //for (int i = 0; i < 40; i++)
            //{
            //    if(i % count == 0)
            //    {

            //        Console.WriteLine("*");
            //        count--;
            //    }
            //    else
            //    {
            //        Console.Write("*");
            //    }
            //}

            // Print 10 stars from left to right
            for (int i = 1; i <= 40; i++)
            {

                //if(i % 2 == 0)
                //{
                //    Console.Write(" ");
                //}
                if (i % count == 0) // Only runs once every 10 times
                {

                    Console.WriteLine("*");
                    count--;
                }
                else
                {

                    Console.Write(" ");

                }

            }
        }

        public static void CallingRecursion()
        {
            // Used for Recursion
            //Counter(0, 20);

            // Count from 20 to 0
            // Start
            // End
            // Change
            //for (int i = 20; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

        }

        // Recursion
        public static void Counter(int number, int end)
        {
            Console.WriteLine(number);

            if (number >= end) return;
            else
            {
                Counter(++number, end);
            }
            Console.WriteLine(number);
        }
        public static void InClassFor()
        {
            // For loop
            // for keyword
            // 3 statements

            // First Statement: Where it starts
            // MIddle Statement: Condition
            // Laster Statement: What it increament or decrements by
            //for(int i = -200; i <= 67; i += 5)
            //{
            //    Console.WriteLine(i);
            //}

            //string userInput = Console.ReadLine();
            //string loginName = "Will";

            //while(userInput != loginName)
            //{
            //    Console.WriteLine("Please enter a valid name");
            //    userInput = Console.ReadLine();
            //}

            //for (
            //    string userInput = Console.ReadLine(); 
            //    userInput != "Will"; 
            //    userInput = Console.ReadLine())
            //{
            //    Console.WriteLine("Please enter a valid name");
            //}

            int count = 0;
            count++; // post 
            ++count; // pre

           
        }



        #region exampleCode

        // Questions to answer
        // What are the three statements in the for loop
        // What's an incrementer and decrementer
        // What does iterate mean
        // What does i mean, and why is it SO crazy important to our code
        // What's the difference between a while and for loop? When should I use one over the other?
        // Scary Question: What is a nested loop

        public static void ForLoopIncrement()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ForLoopDecrement()
        {
            // Fix this
            for (int i = 10; i < 0; i++)
            {
                Console.WriteLine(i);
            }
        }

        #endregion exampleCode

    } // class

} // namespace
