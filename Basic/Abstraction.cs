using System;

namespace Basic
{
    /// <summary>
    /// Represents a general vehicle.
    /// This class provides a template for derived classes to implement specific vehicle behaviors.
    /// </summary>
    public abstract class Vehicle
    {
        #region Public Methods

        /// <summary>
        /// Abstract method to start the vehicle.
        /// Derived classes must provide their own implementation.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Abstract method to stop the vehicle.
        /// Derived classes must provide their own implementation.
        /// </summary>
        public abstract void Stop();

        /// <summary>
        /// Non-abstract method to display the type of vehicle.
        /// This method can be used by all derived classes.
        /// </summary>
        public void DisplayType()
        {
            Console.WriteLine("This is a vehicle.");
        }

        #endregion
    }

    /// <summary>
    /// Represents a car.
    /// Inherits from the Vehicle class and implements its abstract methods.
    /// </summary>
    public class Cars : Vehicle
    {
        #region Public Methods

        /// <summary>
        /// Starts the car.
        /// </summary>
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key ignition.");
        }

        /// <summary>
        /// Stops the car.
        /// </summary>
        public override void Stop()
        {
            Console.WriteLine("Car is stopping by applying brakes.");
        }

        #endregion
    }

    /// <summary>
    /// Represents a bicycle.
    /// Inherits from the Vehicle class and implements its abstract methods.
    /// </summary>
    public class Bicycle : Vehicle
    {
        #region Public Methods

        /// <summary>
        /// Starts the bicycle.
        /// </summary>
        public override void Start()
        {
            Console.WriteLine("Bicycle is starting by pedaling.");
        }

        /// <summary>
        /// Stops the bicycle.
        /// </summary>
        public override void Stop()
        {
            Console.WriteLine("Bicycle is stopping by applying hand brakes.");
        }

        #endregion
    }

    public class Abstraction
    {
        #region Public Methods

        /// <summary>
        /// Abstaction demo method
        /// </summary>
        public static void RunAbstractionDemo()
        {
            Console.WriteLine("Abstraction Examples:\n");

            Vehicle car = new Cars();
            car.DisplayType();
            car.Start();
            car.Stop();

            Console.WriteLine();

            Vehicle bicycle = new Bicycle();
            bicycle.DisplayType();
            bicycle.Start();
            bicycle.Stop();
        }

        #endregion
    }
}
