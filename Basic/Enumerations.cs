using System;

namespace Basic
{
    #region Enumerations

    /// <summary>
    /// Enumeration representing the days of the week.
    /// </summary>
    public enum DaysOfWeek
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    #endregion

    /// <summary>
    /// Demonstrates the use of enumerations in C#.
    /// </summary>
    public class Enumerations
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate Enumerations usage.
        /// </summary>
        public static void RunEnumerationsDemo()
        {
            Console.WriteLine("Understanding Enumerations in C#\n");

            // Using an enumeration value
            DaysOfWeek today = DaysOfWeek.Sunday;
            Console.WriteLine($"Today is: {today}");

            // Getting the underlying integer value of an enum
            int dayValue = (int)today;
            Console.WriteLine($"The numeric value of {today} is: {dayValue}\n");

            // Parsing a string to an enum
            string dayInput = "Friday";
            if (DayOfWeek.TryParse(dayInput, out DayOfWeek dayOutput))
            {
                Console.WriteLine($"Parsed day: {dayOutput} (Numeric Value: {(int)dayOutput})\n");
            }

            // Iterating over enumeration values
            Console.WriteLine("Days of the Week:");
            foreach (var day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                Console.WriteLine($"{day} ({(int)day})");
            }
            Console.WriteLine();

        }

        #endregion
    }
}
