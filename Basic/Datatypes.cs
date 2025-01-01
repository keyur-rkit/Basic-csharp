using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates the use of Datatypes in C#.
    /// </summary>
    public class Datatypes
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate DataType usage.
        /// </summary>
        public static void RunDatatypeDemo()
        {
            // Value Types
            int age = 25;
            float height = 5.9f;
            double weight = 54.5;
            char grade = 'A';
            bool isStudent = true;

            // Reference Types
            string name = "Keyur";
            object obj = 107;

            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Weight: {weight}, Grade: {grade}, Is Student: {isStudent}");

            // Type Conversion
            // Implicit Conversion (Safe Conversion - no data loss)
            int num = 107;
            double bigNum = num;
            Console.WriteLine($"Implicit Conversion: {num} ({num.GetType()}) to {bigNum} ({bigNum.GetType()}) ");

            // Explicit Conversion (Casting - may result in data loss)
            double pi = 3.14;
            int intPi = (int)pi;
            Console.WriteLine($"Explicit Conversion: {pi} to {intPi}");

            // Conversion using Convert Class
            string strNum = "107";
            int parsedNum = Convert.ToInt32(strNum);
            Console.WriteLine($"Convert Class: {strNum} ({strNum.GetType()}) to {parsedNum} ({parsedNum.GetType()}) ");

            // Conversion using Parse Method
            double parsedDouble = double.Parse("45.67");
            Console.WriteLine($"Parse Method: " + parsedDouble);

            // TryParse Method (Safe Conversion without exceptions)
            string invalidInput = "A107";
            bool isSuccess = int.TryParse(invalidInput, out int result);
            Console.WriteLine($"TryParse Result: Success = {isSuccess}, Value = {result}");

            // Boxing and Unboxing
            // Boxing: Value Type to Object
            object boxed = age;
            Console.WriteLine($"Boxing: {boxed} ");


            // Unboxing: Object to Value Type
            int unboxed = (int)boxed;
            Console.WriteLine($"Unboxing: {unboxed} ");
        }

        #endregion
    }
}
