using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates various exception handling techniques in C#.
    /// </summary>
    public class ExceptionHandling
    {
        #region Public Methods

        /// <summary>
        /// Entry point of demonstration of ExceptionHandling
        /// </summary>
        public static void RunExceptionHandlingDemo()
        {
            Console.WriteLine("Exception Handling in C#\n");

            try
            {
                // Example: Division by zero
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator; // This will throw a DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught a DivideByZeroException: " + ex.Message);
            }

            try
            {
                // Example: Array index out of bounds
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught an IndexOutOfRangeException: " + ex.Message);
            }

            try
            {
                // Example: Null reference exception
                string text = null;
                Console.WriteLine(text.Length); // This will throw a NullReferenceException
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Caught a NullReferenceException: " + ex.Message);
            }

            try
            {
                // General exception handling
                int[] data = null;
                Console.WriteLine(data.Length); // This will throw a NullReferenceException
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught a general exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            // Example of custom exception handling
            try
            {
                ValidateAge(-5);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Custom Exception Caught: " + ex.Message);
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates age and throws an exception if invalid.
        /// </summary>
        /// <param name="age">Age to validate.</param>
        /// <exception cref="ArithmeticException">Thrown when age is less than zero.</exception>
        static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArithmeticException("Age cannot be negative.");
            }

            Console.WriteLine("Age is valid.");
        }

        #endregion
    }
}
