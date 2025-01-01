using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates arrays of statements in C#.
    /// </summary>
    public class Arrays
    {
        #region Public Methods

        /// <summary>
        /// Array demo method
        /// </summary>
        public static void RunArraysDemo()
        {
            // Single-Dimensional Array
            Console.WriteLine("Single-Dimensional Array:");
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Elements in the array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            // Accessing and Modifying Array Elements
            Console.WriteLine("\n\nAccessing and Modifying Array Elements:");
            Console.WriteLine($"First Element: {numbers[0]}");
            numbers[0] = 15;
            Console.WriteLine($"Updated First Element: {numbers[0]}");

            // Multi-Dimensional Array
            Console.WriteLine("\nMulti-Dimensional Array:");
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Console.WriteLine("Elements in the matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged Array
            Console.WriteLine("\nJagged Array:");
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("Elements in the jagged array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                foreach (int val in jaggedArray[i])
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }

            // Array Class Methods
            Console.WriteLine("\nArray Class Methods:");
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            int index = Array.IndexOf(numbers, 30);
            Console.WriteLine($"\nIndex of 30: {index}");

            Array.Reverse(numbers);
            Console.WriteLine("Reversed Array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            // Length and Rank of an Array
            Console.WriteLine("\n\nLength and Rank of Arrays:");
            Console.WriteLine($"Length of numbers array: {numbers.Length}");
            Console.WriteLine($"Rank of matrix array: {matrix.Rank}");
        }

        #endregion
    }
}
