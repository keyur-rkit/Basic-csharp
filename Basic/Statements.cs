using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates various types of statements in C#.
    /// </summary>
    public class Statements
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate different types of statements.
        /// </summary>
        public static void RunStatementsDemo()
        {
            // Declaration Statement
            int number;
            number = 10; // Assignment Statement
            Console.WriteLine($"Declaration and Assignment: number = {number}");

            // Expression Statement
            number = number + 5;
            Console.WriteLine($"Expression Statement: number + 5 = {number}");

            // Conditional Statement
            Console.WriteLine("\nConditional Statement:");
            if (number > 10)
            {
                Console.WriteLine("number is greater than 10");
            }
            else
            {
                Console.WriteLine("number is not greater than 10");
            }

            // Iteration Statement - For Loop
            Console.WriteLine("\nIteration Statement (For Loop):");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }

            // Iteration Statement - While Loop
            Console.WriteLine("\nIteration Statement (While Loop):");
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine($"Count = {count}");
                count++;
            }

            // Iteration Statement - Do-While Loop
            Console.WriteLine("\nIteration Statement (Do-While Loop):");
            count = 0;
            do
            {
                Console.WriteLine($"Count = {count}");
                count++;
            } while (count < 3);

            // Switch Statement
            Console.WriteLine("\nSwitch Statement:");
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }

            // Jump Statements
            Console.WriteLine("\nJump Statements:");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    continue; // Skips the rest of the loop when i == 3
                Console.WriteLine($"i = {i}");
                if (i == 4)
                    break; // Exits the loop when i == 4
            }

        }

        #endregion
    }
}
