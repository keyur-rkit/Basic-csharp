using System;

namespace Basic
{
    /// <summary>
    /// Compile-Time Polymorphism Example
    /// </summary>
    public class ShapeCalculator
    {
        #region Public Methods

        /// <summary>
        /// Calculates the area of a rectangle.
        /// </summary>
        /// <param name="length">The length of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <returns>The area of the rectangle.</returns>
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>The area of the circle.</returns>
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        #endregion
    }

    /// <summary>
    /// Run-Time Polymorphism Example
    /// </summary>
    public class Employees
    {
        #region Public Methods

        /// <summary>
        /// Virtual method to calculate the bonus of an employee.
        /// </summary>
        public virtual void CalculateBonus()
        {
            Console.WriteLine("Generic employee bonus.");
        }

        #endregion
    }

    /// <summary>
    /// Represents a full-time employee.
    /// </summary>
    public class FullTimeEmployee : Employees
    {
        #region Public Methods

        /// <summary>
        /// Overrides the CalculateBonus method for a full-time employee.
        /// </summary>
        public override void CalculateBonus()
        {
            Console.WriteLine("Full-time employee bonus is 20% of salary.");
        }

        #endregion
    }

    /// <summary>
    /// Represents a part-time employee.
    /// </summary>
    public class PartTimeEmployee : Employees
    {
        #region Public Methods

        /// <summary>
        /// Overrides the CalculateBonus method for a part-time employee.
        /// </summary>
        public override void CalculateBonus()
        {
            Console.WriteLine("Part-time employee bonus is 10% of salary.");
        }

        #endregion
    }

    /// <summary>
    /// Demonstrates Polymorphism in C#.
    /// </summary>
    public class Polymorphism
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate Polymorphism
        /// </summary>
        public static void RunPolymorphismDemo()
        {
            // Compile-Time Polymorphism Demonstration
            ShapeCalculator shapeCalculator = new ShapeCalculator();
            Console.WriteLine("Compile-Time Polymorphism Examples:");
            Console.WriteLine($"Rectangle Area (5, 10): {shapeCalculator.CalculateArea(5, 10)}");
            Console.WriteLine($"Circle Area (radius 7): {shapeCalculator.CalculateArea(7)}");

            // Run-Time Polymorphism Demonstration
            Employees employee = new Employees();
            Employees fullTimeEmployee = new FullTimeEmployee();
            Employees partTimeEmployee = new PartTimeEmployee();

            Console.WriteLine("\nRun-Time Polymorphism Examples:");
            employee.CalculateBonus();
            fullTimeEmployee.CalculateBonus();
            partTimeEmployee.CalculateBonus();
        }

        #endregion
    }
}
