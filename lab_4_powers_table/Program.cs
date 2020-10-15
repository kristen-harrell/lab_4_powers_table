using System;
using System.Dynamic;

namespace lab_4_powers_table
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;

            Console.WriteLine("Learn your squares and cubes!");

            while (userContinue)

            {
                int userNumber;

                Console.Write("Please enter an integer:");

                while (!int.TryParse(Console.ReadLine(), out userNumber))
                    Console.Write("Your entry is not a number.  Please try again: ");

                Console.WriteLine("Number          Squared          Cubed");
                Console.WriteLine("=====           ======           =====");

                for (int i = 1; i <= userNumber; i++)
                {
                    Console.WriteLine($"{i,-15} {SolutionSquared(i), -16} {SolutionCubed(i)}");
                }

                Console.Write("Would you like to enter another integer? y/n: ");
                string continueInput = Console.ReadLine();
                if (continueInput == "y")
                {
                    userContinue = true;
                }
                else
                {
                    Console.WriteLine("Ok, bye!!");
                    break;
                }

            }
        }
        public static int SolutionSquared(int input)
        {
            int output = input * input;

            return output;
        }

        public static int SolutionCubed(int input)
        {
            int output = input * input * input;

            return output;
        }


    }
}
