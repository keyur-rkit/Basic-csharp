using System;

namespace Basic
{
    /// <summary>
    /// This interface defines the behavior for drawable objects.
    /// </summary>
    public interface IDrawable
    {
        void Draw();
    }

    /// <summary>
    /// This interface defines the behavior for movable objects.
    /// </summary>
    public interface IMovable
    {
        void Move();
    }

    /// <summary>
    /// This class represents a shape that implements both drawable and movable interfaces.
    /// </summary>
    public class Shape : IDrawable, IMovable
    {
        #region Public Methods
        /// <summary>
        /// Implements the Draw method of the IDrawable interface.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing the shape.");
        }

        /// <summary>
        /// Implements the Move method of the IMovable interface.
        /// </summary>
        public void Move()
        {
            Console.WriteLine("Moving the shape.");
        }
        #endregion
    }

    /// <summary>
    /// Demonstrates MultipleInheritance in C#.
    /// </summary>
    public class MultipleInheritance
    {
        #region Public Methods
        /// <summary>
        /// Entry point to demonstrate MultipleInheritance 
        /// </summary>
        public static void RunMultipleInheritanceDemo()
        {
            // Create an instance of the Shape class.
            Shape shape = new Shape();

            // Call the Draw and Move methods.
            shape.Draw();
            shape.Move();
        }
        #endregion
    }
}
