using System;

namespace Basic
{
    /// <summary>
    /// Student class to demonstrate encapsulation.
    /// </summary>
    public class Student
    {
        #region Private Members

        private string _name;
        private int _age;
        private double _cgpa;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Student class.
        /// </summary>
        /// <param name="name">The name of the student.</param>
        /// <param name="age">The age of the student.</param>
        /// <param name="cgpa">The CGPA of the student.</param>
        public Student(string name, int age, double cgpa)
        {
            if (age > 0)
            {
                _age = age;
            }

            if (cgpa >= 4.0 && cgpa <= 10.0)
            {
                _cgpa = cgpa;
            }

            _name = name;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the student's name.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets or sets the student's age.
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the student's CGPA.
        /// </summary>
        public double CGPA
        {
            get { return _cgpa; }
            set
            {
                if (value >= 4.0 && value <= 10.0)
                {
                    _cgpa = value;
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// Demonstrates the concept of encapsulation in C#.
    /// </summary>
    public class Encapsulation
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate Encapsulation.
        /// </summary>
        public static void RunEncapsulationDemo()
        {
            // Create a new student instance.
            Student student = new Student("Keyur", 20, 9.17);

            // Display student information.
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"GPA: {student.CGPA}");

            // Update student details.
            //student.Name = "raj";  // error (Name does not have set method)
            student.Age = 21;
            student.CGPA = 3; // no change 

            // Display updated information.
            Console.WriteLine("Updated Student Information:");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"GPA: {student.CGPA}");
        }

        #endregion
    }
}
