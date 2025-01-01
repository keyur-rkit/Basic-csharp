using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates namespace in C#.
    /// </summary>
    public class Namespace
    {
        /// <summary>
        /// local PrintHello method
        /// </summary>
        static void PrintHello()
        {
            Console.WriteLine("Hello!!");
        }

        /// <summary>
        /// Entry point to demonstrate namespace 
        /// </summary>
        public static void RunNamespaceDemo()
        {
            Console.WriteLine("Demonstrating Namespaces\n");

            PrintHello();
            // Demonstrating Custom Namespace Usage
            Utilities.Custom.PrintHello();
        }
    }
}

/// <summary>
/// A custom namespace to demonstrate user-defined namespaces.
/// </summary>
namespace Utilities
{
    /// <summary>
    /// Utility class with helper methods.
    /// </summary>
    public static class Custom
    {
        /// <summary>
        /// Prints a Hello message.
        /// </summary>
        public static void PrintHello()
        {
            Console.WriteLine("Hello from custom namespace!!");
        }
    }
}