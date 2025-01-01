using System;
using TaxLibrary;

namespace Basic
{
    /// <summary>
    /// Demonstrates referencing an external assembly.
    /// </summary>
    public class Reference
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate Reference usage.
        /// </summary>
        public static void RunReferenceDemo()
        {
            Console.WriteLine("Demonstrating Assembly References\n");

            // Referencing a method from an external assembly
            double amount = 1500.75;
            double taxRate = 0.18;

            double tax = TaxCalculator.CalculateTax(amount, taxRate);
            Console.WriteLine($"For an amount of {amount}, the calculated tax is {tax}.");
        }

        #endregion
    }
}
