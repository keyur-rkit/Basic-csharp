using System;

namespace Basic
{
    /// <summary>
    /// A base class representing a generic Employee.
    /// </summary>
    class Employee
    {
        #region Public Properties

        public string Name;
        public int EmployeeID;

        #endregion

        #region Constructors

        public Employee()
        {
            Console.WriteLine("Employee class!!");
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Method to display basic employee information.
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee: {Name}, ID: {EmployeeID}");
        }

        #endregion
    }

    /// <summary>
    /// A derived class representing a Manager.
    /// Single Inheritance.
    /// </summary>
    class Manager : Employee
    {
        #region Public Properties

        public int TeamSize;

        #endregion

        #region Constructors

        public Manager()
        {
            Console.WriteLine("Manager class!");
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Method to display manager-specific information.
        /// </summary>
        public void DisplayManagerInfo()
        {
            Console.WriteLine($"Manager: {Name}, ID: {EmployeeID}, Team Size: {TeamSize}");
        }

        #endregion
    }

    /// <summary>
    /// A derived class representing a ProjectManager.
    /// Multilevel Inheritance.
    /// </summary>
    class ProjectManager : Manager
    {
        #region Public Properties

        public string ProjectName;

        #endregion

        #region Constructors

        public ProjectManager()
        {
            Console.WriteLine("ProjectManager Class!!");
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Method to display project manager-specific information.
        /// </summary>
        public void DisplayProjectManagerInfo()
        {
            Console.WriteLine($"Project Manager: {Name}, ID: {EmployeeID}, Team Size: {TeamSize}, Project: {ProjectName}");
        }

        #endregion
    }

    /// <summary>
    /// A derived class representing an Intern.
    /// Hierarchical Inheritance.
    /// </summary>
    class Intern : Employee
    {
        #region Public Properties

        public string MentorName;

        #endregion

        #region Constructors

        public Intern()
        {
            Console.WriteLine("Intern Class!!");
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Method to display intern-specific information.
        /// </summary>
        public void DisplayInternInfo()
        {
            Console.WriteLine($"Intern: {Name}, ID: {EmployeeID}, Mentor: {MentorName}");
        }

        #endregion
    }

    public class Inheritance
    {
        #region Public Methods

        public static void RunInheritanceDemo()
        {
            Console.WriteLine("Demonstrating Different Types of Inheritance\n");

            // Single Inheritance
            Manager manager = new Manager { Name = "Keyur", EmployeeID = 107, TeamSize = 5 };
            manager.DisplayEmployeeInfo();
            manager.DisplayManagerInfo();

            Console.WriteLine();

            // Multilevel Inheritance
            ProjectManager projectManager = new ProjectManager { Name = "Hit", EmployeeID = 106, TeamSize = 10, ProjectName = "Web Development" };
            projectManager.DisplayEmployeeInfo();
            projectManager.DisplayManagerInfo();
            projectManager.DisplayProjectManagerInfo();

            Console.WriteLine();

            // Hierarchical Inheritance
            Intern intern = new Intern { Name = "Raj", EmployeeID = 25, MentorName = "Keyur" };
            intern.DisplayEmployeeInfo();
            intern.DisplayInternInfo();
        }

        #endregion
    }
}
