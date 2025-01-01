using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates the usage of the String class in C#.
    /// </summary>
    public class StringClass
    {
        #region Public Methods

        /// <summary>
        /// Demonstrates working with the String class in C#.
        /// </summary>
        public static void RunStringClassDemo()
        {
            Console.WriteLine("Working with String Class in C#\n");

            // Declaring and initializing strings
            string greeting = "Hello, World!";
            string name = "Keyur";
            Console.WriteLine($"Greeting: {greeting}");

            // String concatenation
            string concatenated = greeting + " Welcome, " + name + "!";
            Console.WriteLine($"Concatenated String: {concatenated}");

            // String interpolation
            string interpolated = $"Hello, {name}! Today is {DateTime.Now:dddd, MMMM dd, yyyy}.";
            Console.WriteLine($"Interpolated String: {interpolated}");

            // Accessing characters in a string
            Console.WriteLine($"First character of greeting: {greeting[0]}");

            // String methods
            Console.WriteLine($"Uppercase: {greeting.ToUpper()}");
            Console.WriteLine($"Lowercase: {greeting.ToLower()}");
            Console.WriteLine($"Length of greeting: {greeting.Length}");
            Console.WriteLine($"Substring (start at index 7): {greeting.Substring(7)}");
            Console.WriteLine($"Replace 'World' with 'C#': {greeting.Replace("World", "C#")}");

            // Using IndexOf and LastIndexOf
            string sentence = "Programming in C# is fun and productive.";
            Console.WriteLine($"IndexOf 'C#': {sentence.IndexOf("C#")}");
            Console.WriteLine($"LastIndexOf 'and': {sentence.LastIndexOf("and")}");

            // Using Trim
            string paddedString = "   Extra spaces   ";
            Console.WriteLine($"Original with spaces: '{paddedString}'");
            Console.WriteLine($"Trimmed: '{paddedString.Trim()}'");

            // Using Insert
            string baseString = "C# is great.";
            string insertedString = baseString.Insert(6, "really ");
            Console.WriteLine($"Original: {baseString}");
            Console.WriteLine($"After Insert: {insertedString}");

            // Splitting and joining strings
            sentence = "C# is a modern, object-oriented programming language.";
            string[] words = sentence.Split(' ');
            Console.WriteLine("Words in the sentence:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            string joined = string.Join(" ", words);
            Console.WriteLine($"Joined String: {joined}");

            // Checking for null or empty strings
            string emptyString = "";
            string nullString = null;

            Console.WriteLine($"Is emptyString null or empty? {string.IsNullOrEmpty(emptyString)}");
            Console.WriteLine($"Is nullString null or empty? {string.IsNullOrEmpty(nullString)}");
        }

        #endregion
    }
}
