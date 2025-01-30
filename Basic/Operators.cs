using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates operators in C#.
    /// </summary>
    public class Operators
    {
        #region Public Methods
        /// <summary>
        /// Entry point to demonstrate operator usage.
        /// </summary>
        public static void RunOperatorsDemo()
        {
            // Arithmetic Operators
            int num1 = 10;
            int num2 = 3;
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"Modulus: {num1} % {num2} = {num1 % num2}");

            // Relational (Comparison) Operators
            Console.WriteLine("\nRelational Operators:");
            Console.WriteLine($"{num1} == {num2}: {num1 == num2}");
            Console.WriteLine($"{num1} != {num2}: {num1 != num2}");
            Console.WriteLine($"{num1} > {num2}: {num1 > num2}");
            Console.WriteLine($"{num1} < {num2}: {num1 < num2}");
            Console.WriteLine($"{num1} >= {num2}: {num1 >= num2}");
            Console.WriteLine($"{num1} <= {num2}: {num1 <= num2}");

            // Logical Operators
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine($"isTrue AND isFalse: {isTrue && isFalse}");
            Console.WriteLine($"isTrue OR isFalse: {isTrue || isFalse}");
            Console.WriteLine($"NOT isTrue: {!isTrue}");

            // Assignment Operators
            int result = 5;
            Console.WriteLine("\nAssignment Operators:");
            result += 3;
            Console.WriteLine($"result += 3: {result}");
            result -= 2;
            Console.WriteLine($"result -= 2: {result}");
            result *= 2;
            Console.WriteLine($"result *= 2: {result}");
            result /= 3;
            Console.WriteLine($"result /= 3: {result}");
            result %= 2;
            Console.WriteLine($"result %= 2: {result}");

            // Bitwise Operators
            int value1 = 5; // 0101 in binary
            int value2 = 3; // 0011 in binary
            Console.WriteLine("\nBitwise Operators:");
            Console.WriteLine($"value1 & value2 (AND): {value1 & value2}");
            Console.WriteLine($"value1 | value2 (OR): {value1 | value2}");
            Console.WriteLine($"value1 ^ value2 (XOR): {value1 ^ value2}");
            Console.WriteLine($"~value1 (NOT): {~value1}");

            // Conditional (Ternary) Operator
            int personAge = 20;
            string eligibility = personAge >= 18 ? "Eligible" : "Not Eligible";
            Console.WriteLine("\nConditional Operator:");
            Console.WriteLine($"Age: {personAge}, Eligibility: {eligibility}");

            // Expressions
            Console.WriteLine("\nExpressions:");
            int expressionResult = (num1 + num2) * (result - 1);
            Console.WriteLine($"Expression Result: (num1 + num2) * (result - 1) = {expressionResult}");

            // Extra
            // Index from end operator ^
            int[] xs = { 0, 10, 20, 30, 40 };
            int last = xs[^1];
            Console.WriteLine($"\nUsing ^ to find last element : {last}");

            // Range ..
            int[] numbers = { 0, 10, 20, 30, 40, 50 };
            int start = 1;
            int amountToTake = 3;
            int[] subset = numbers[start..(start + amountToTake)];
            Console.WriteLine($"\nUsing Range .. : {subset[0]} {subset[1]} {subset[2]} ");

            // is 
            object objInt = 123;
            if (objInt is int)
            {
                Console.WriteLine("\nobj is an integer. (checking using is operator)");
            }

            // as
            object objString = "Hello, World!";
            string str = objString as string; // Safe cast to string
            if (str != null)
            {
                Console.WriteLine($"\nCast to string using as : {str}");
            }
            else
            {
                Console.WriteLine("\nConversion failed.");
            }

            // typeof
            Console.WriteLine($"\nTypeof int : {typeof(int)}");

            // Null Conditional Operator ?.
            string name = null;
            int? length = name?.Length;
            Console.WriteLine($"\nUsing ?. operator : {length} (blank, as it's null)");

            // Null Coalescing Operator ?? 
            string username = null;
            string displayName = username ?? "Unknown";
            Console.WriteLine($"\nUsing ?? operator : {displayName}");

            // sizeof operator
            Console.WriteLine($"\nsizeof double : {sizeof(double)}");
        }
        #endregion
    }
}
