using System;
using System.Collections;
using System.Collections.Generic;

namespace Basic
{
    /// <summary>
    /// Demonstrates the use of various collections in C#.
    /// </summary>
    public class Collections
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate collections usage.
        /// </summary>
        public static void RunCollectionsDemo()
        {
            Console.WriteLine("Working with Collections in C#\n");

            // ArrayList (Non-generic collection)
            ArrayListExample();

            // List<T> (Generic collection)
            ListExample();

            // Dictionary<TKey, TValue> (Key-value pair collection)
            DictionaryExample();

            // Queue<T> (FIFO collection)
            QueueExample();

            // Stack<T> (LIFO collection)
            StackExample();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Demonstrates the use of an ArrayList.
        /// </summary>
        private static void ArrayListExample()
        {
            Console.WriteLine("ArrayList Example:");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add(3.0);
            arrayList.Add(1);
            arrayList.Remove(1);
            arrayList.RemoveRange(2,1);

            foreach (var item in arrayList)
            {
                Console.WriteLine($"Item: {item} (Type: {item.GetType()})");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates the use of a List<T>.
        /// </summary>
        private static void ListExample()
        {
            Console.WriteLine("List<T> Example:");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            numbers.Add(6);
            numbers.Remove(5);

            List<int> extraNumbers = new List<int> { 8, 9, 10, 11 };
            numbers.AddRange(extraNumbers);

            Console.WriteLine($"Count: {numbers.Count}");
            Console.WriteLine($"Capacity: {numbers.Capacity}");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates the use of a Dictionary<TKey, TValue>.
        /// </summary>
        private static void DictionaryExample()
        {
            Console.WriteLine("Dictionary<TKey, TValue> Example:");
            Dictionary<string, string> countries = new Dictionary<string, string>
            {
                { "US", "United States" },
                { "IN", "India" },
                { "UK", "United Kingdom" }
            };

            foreach (var kvp in countries)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates the use of a Queue<T>.
        /// </summary>
        private static void QueueExample()
        {
            Console.WriteLine("Queue<T> Example:");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates the use of a Stack<T>.
        /// </summary>
        private static void StackExample()
        {
            Console.WriteLine("Stack<T> Example:");
            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine();
        }

        #endregion
    }
}
