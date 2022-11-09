using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12_ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

        } // Main

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
