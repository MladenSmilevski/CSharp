using System;

namespace Homework_No._1_Це_Шарп
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework No. 1
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Homework No. 1");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" Stop  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Ready ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("   Go  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            #region Homework No.2
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Homework No. 2");

            #region Exercise 01

            Console.WriteLine();
            Console.WriteLine("Exercise 1");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;

            /* DECLARE TWO STRING VARIABLES
            INITIALIZE THEM AND CONCATENATE THEM IN A NEW VARIABLE
            DECLARE TWO STRING VARIABLES
            INITIALIZE THEM WITH THE NUMBER 9 AND 3
            CONCATENATE THEM IN A NEW VARIABLE
            PRINT THE RESULTS IN THE CONSOLE */
            string first = "First";
            string second = "Second";
            string concatOne = first + second;

            string third = "9";
            string fouth = "3";
            string concatTwo = third + fouth;

            Console.WriteLine(concatOne);
            Console.WriteLine(concatTwo);
            #endregion
            #region Exercise 02
            /*Declare an integer and a string variable
            Initialize them and concatenate them in a new variable
            Print the result in the console*/
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Exercise 2");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;

            int numOne = 356;
            string strOne = ":(threehundredfiftyfive)";
            var concatThree = numOne + strOne;
            Console.WriteLine(concatThree);
            #endregion
            #region Exercise 03
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Exercise 3");
            /*You have n credits on your mobile bill. One SMS costs m credits.How many SMS messages you can send?
            n = 102
            m = 5
            Result = ?*/
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            int n = 102;
            int m = 5;
            int result = n / m;
            Console.WriteLine("You can send " + result + " messages!");
            #endregion
            #region Exercise 04
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Exercise 4");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            /*Set variable from input
            TRY to convert it to int
            if its converted successfully print in the console if number is odd or even
            else if its not converted, print in the console that user inserted invalid input
            Hint: if number / 2 has remainder 0 its even, else its odd*/
            Console.WriteLine("Please enter a number:");
            string num = Console.ReadLine();
            bool numberValue = int.TryParse(num, out result);
            if (numberValue == false)
            {
                Console.WriteLine("You have inserted invalid input, please enter a number!");
            }
            else
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                if (result % 2 != 0)
                {
                    Console.WriteLine("The number is odd");
                }
            }
            #endregion
            #endregion
            Console.ReadLine();
        }
    }
}
