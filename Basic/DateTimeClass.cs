using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates the use of the DateTime class in C#.
    /// </summary>
    public class DateTimeClass
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate DataTime Class usage.
        /// </summary>
        public static void RunDateTimeClassDemo()
        {
            // Create DateTime instances
            DateTime currentDate = DateTime.Now; // Gets the current date and time
            int year = currentDate.Year;
            Console.WriteLine(year);
            DateTime specificDate = new DateTime(2024, 12, 18); // Represents December 18, 2024
            DateTime specificDateTime = new DateTime(2024, 12, 18, 14, 30, 0); // December 18, 2024, 2:30 PM

            Console.WriteLine("DateTime Examples:\n");

            // Displaying the current date and time
            Console.WriteLine($"Current Date and Time: {currentDate}");

            // Displaying a specific date
            Console.WriteLine($"Specific Date: {specificDate.ToShortDateString()}");

            // Displaying a specific date and time
            Console.WriteLine($"Specific Date and Time: {specificDateTime}");

            // Manipulating DateTime values
            DateTime tomorrow = currentDate.AddDays(1); // Adds 1 day to the current date
            DateTime nextMonth = currentDate.AddMonths(1); // Adds 1 month to the current date
            DateTime lastWeek = currentDate.AddDays(-7); // Subtracts 7 days (1 week) from the current date

            Console.WriteLine($"Tomorrow: {tomorrow.ToShortDateString()}");
            Console.WriteLine($"Next Month: {nextMonth.ToShortDateString()}");
            Console.WriteLine($"Last Week: {lastWeek.ToShortDateString()}");

            // Comparing DateTime values
            int comparisonResult = specificDate.CompareTo(currentDate);
            if (comparisonResult > 0)
            {
                Console.WriteLine($"{specificDate.ToShortDateString()} is in the future.");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine($"{specificDate.ToShortDateString()} is in the past.");
            }
            else
            {
                Console.WriteLine($"{specificDate.ToShortDateString()} is today.");
            }

            // Formatting DateTime values
            Console.WriteLine($"Long Date Format: {currentDate.ToLongDateString()}");
            Console.WriteLine($"Long Time Format: {currentDate.ToLongTimeString()}");
            Console.WriteLine($"Custom Format (dd-MM-yyyy HH:mm): {currentDate:dd-MM-yyyy HH:mm}");

            // Parsing DateTime strings
            string dateString = "2024-12-18";
            if (DateTime.TryParse(dateString, out DateTime parsedDate))
            {
                Console.WriteLine($"Parsed Date: {parsedDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine("Invalid date string.");
            }

            // TimeSpan usage with DateTime
            DateTime futureDate = currentDate.AddDays(10);
            TimeSpan difference = futureDate - currentDate;
            Console.WriteLine($"Days until {futureDate.ToShortDateString()}: {difference.Days} days");
        }

        #endregion
    }
}
