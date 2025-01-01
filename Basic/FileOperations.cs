using System;
using System.IO;

namespace Basic
{
    /// <summary>
    /// Demonstrates basic file operations in C#.
    /// This includes creating, writing, reading, appending, and deleting files.
    /// </summary>
    public class FileOperations
    {
        #region Public Methods
        /// <summary>
        /// Entry point to demonstrate File operations usage.
        /// </summary>
        public static void RunFileOperationsDemo()
        {
            string filePath = @"test.txt";

            Console.WriteLine("Basic File Operations:\n");

            // 1. Create and Write to a File
            Console.WriteLine("Creating and writing to the file...");
            File.WriteAllText(filePath, "Hello, this is the first line of the file!\n");
            Console.WriteLine("File created and initial content written.\n");

            // 2. Read the File
            Console.WriteLine("Reading the file...");
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content:");
            Console.WriteLine(content);

            // 3. Append to the File
            Console.WriteLine("Appending to the file...");
            File.AppendAllText(filePath, "This is an appended line.\n");
            Console.WriteLine("Content appended.\n");

            // 4. Read the File Again
            Console.WriteLine("Reading the updated file...");
            string updatedContent = File.ReadAllText(filePath);
            Console.WriteLine("Updated File Content:");
            Console.WriteLine(updatedContent);

            // 5. Check if the File Exists
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nThe file exists.");
            }
            else
            {
                Console.WriteLine("\nThe file does not exist.");
            }

            // 6. Delete the File
            Console.WriteLine("Deleting the file...");
            File.Delete(filePath);
            Console.WriteLine("File deleted.");

            // Confirm Deletion
            if (!File.Exists(filePath))
            {
                Console.WriteLine("\nFile has been successfully deleted.");
            }
            else
            {
                Console.WriteLine("\nFile still exists.");
            }
        }
        #endregion
    }
}
