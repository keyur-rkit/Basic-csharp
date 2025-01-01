using System;

namespace Basic
{
    /// <summary>
    /// A class representing a basic blueprint for a Car.
    /// </summary>
    class Car
    {
        #region Private Members

        private string make;
        private string model;
        private int year;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor to initialize the Car object.
        /// </summary>
        /// <param name="make">The make of the car.</param>
        /// <param name="model">The model of the car.</param>
        /// <param name="year">The manufacturing year of the car.</param>
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the details of the car.
        /// </summary>
        /// <returns>A string containing the car's details.</returns>
        public string GetCarDetails()
        {
            return $"{year} {make} {model}";
        }

        /// <summary>
        /// Starts the car.
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"{GetCarDetails()} is starting...");
        }

        /// <summary>
        /// Stops the car.
        /// </summary>
        public void Stop()
        {
            Console.WriteLine($"{GetCarDetails()} has stopped.");
        }

        #endregion
    }

    public class Classes
    {
        #region Public Methods

        /// <summary>
        /// Classes demo method
        /// </summary>
        public static void RunClassesDemo()
        {
            Console.WriteLine("Understanding Classes and Basic OOP Concepts\n");

            // Creating an object of the Car class
            Car myCar = new Car("Hyundai", "Creta", 2015);

            // Accessing methods of the Car object
            myCar.Start();
            myCar.Stop();

        }

        #endregion
    }
}
