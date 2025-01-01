using System;
using System.IO;

namespace Basic
{
    /// <summary>
    /// Demonstrates use of StreamReader and StreamWriter.
    /// </summary>
    public class ReFileOperations
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate StreamReader and StreamWriter.
        /// </summary>
        public static void RunReFileOperations()
        {
            // path for reading or writing
            string path = @"C:\Users\Asus\source\repos\TestFiles\test1.txt";

            //StreamWriter writer = new StreamWriter(path);
            //writer.WriteLine("This is first trial");
            //writer.Flush();
            //writer.Close();

            // writing into file using StreamWriter
            using (StreamWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine("This is test line");
            }

            // reading from file using StreamReader
            Console.WriteLine("\n Reading Line :");
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.Peek() > -1)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }

            // reverse reading from file using FileStream and Seek method
            Console.WriteLine("\n Reading line in reverse :");
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                for (int i = 1; i <= fs.Length; i++)
                {
                    fs.Seek(-i, SeekOrigin.End);
                    Console.Write((char)fs.ReadByte());
                }
            }

        }

        #endregion
    }
}
