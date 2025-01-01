using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates defining and calling methods in C#.
    /// </summary>
    public class Methods
    {
        #region Public Methods
        /// <summary>
        /// Entry point to demonstrate methods usage.
        /// </summary>
        public static void RunMethodsDemo()
        {
            Console.WriteLine("Calling Methods in C#");

            // Call a method without return value
            PrintGreeting();

            // Call a method with parameters
            Console.WriteLine("\nMethod with Parameters:");
            PrintMessage("Welcome to C# Programming!");

            // Call a method with return value
            Console.WriteLine("\nMethod with Return Value:");
            int result = AddNumbers(5, 10);
            Console.WriteLine($"Sum: {result}");

            // Call an overloaded method
            Console.WriteLine("\nOverloaded Method:");
            int product = Multiply(4, 5);
            double productDouble = Multiply(2.5, 3.5);
            Console.WriteLine($"Product (int): {product}");
            Console.WriteLine($"Product (double): {productDouble}");

            // Call an method with ref keyword
            Console.WriteLine("\nMethod with ref keyword:");
            int originalValue = 20;
            Console.WriteLine($"Original value: {originalValue}");
            DoubleValue(ref originalValue);
            Console.WriteLine($"After ref method call: {originalValue}");

            // Call an method with out keyword
            Console.WriteLine("\nMethod with out keyword:");
            int length = 5;
            int area;
            int perimeter;
            Square(length, out area, out perimeter);
            Console.WriteLine($"Area : {area} , Perimeter : {perimeter} ");
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// A simple method without return value or parameters.
        /// </summary>
        static void PrintGreeting()
        {
            Console.WriteLine("Hello! This is a simple method.");
        }

        /// <summary>
        /// A method that takes parameters and does not return a value.
        /// </summary>
        /// <param name="message">Message to print.</param>
        static void PrintMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        /// <summary>
        /// A method that takes parameters and returns a value.
        /// </summary>
        /// <param name="num1">First number.</param>
        /// <param name="num2">Second number.</param>
        /// <returns>Sum of num1 and num2.</returns>
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// An overloaded method to multiply two integers.
        /// </summary>
        /// <param name="num1">First integer.</param>
        /// <param name="num2">Second integer.</param>
        /// <returns>Product of num1 and num2.</returns>
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// An overloaded method to multiply two doubles.
        /// </summary>
        /// <param name="num1">First double.</param>
        /// <param name="num2">Second double.</param>
        /// <returns>Product of num1 and num2.</returns>
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// A method that uses the ref keyword to modify the original variable.
        /// </summary>
        /// <param name="value">The value to be doubled.</param>
        static void DoubleValue(ref int value)
        {
            Console.WriteLine("Doubling the value...");
            value *= 2;
        }

        /// <summary>
        /// A method that uses the out keyword to assign multiple variables.
        /// </summary>
        /// <param name="length">The length of the Square</param>
        /// <param name="area">The area of the Square to be found</param>
        /// <param name="perimeter">The perimeter of the Square to be found</param>
        static void Square(int length, out int area, out int perimeter)
        {
            area = length * length;
            perimeter = 4 * length;
        }
        #endregion
    }
}
