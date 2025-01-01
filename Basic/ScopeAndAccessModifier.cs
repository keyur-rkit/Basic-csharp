using System;

namespace Basic
{
    /// <summary>
    /// Demonstrates Scope and Access Modifier in C#.
    /// </summary>
    public class ScopeAndAccessModifier
    {
        #region Public Methods

        /// <summary>
        /// Run the demo for Scope and Access Modifiers.
        /// </summary>
        public static void RunScopeAndAccessModifierDemo()
        {
            ScopeAndAccessibility obj = new ScopeAndAccessibility();
            obj.publicField = 10;
            // obj.privateField = 20; // Not accessible

            obj.PublicMethod();
            //obj.PrivateMethod(); // Not accessible
            //obj.ProtectedMethod(); // Not accessible
            obj.InternalMethod();
            obj.ProtectedInternalMethod();

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.publicField = 30;
            // derivedObj.privateField = 40; // Not accessible
            // derivedObj.protectedField = 50; // Not accessible
            derivedObj.internalField = 60;
            derivedObj.protectedInternalField = 70;

            derivedObj.DerivedMethod();
        }

        #endregion

        #region Public Classes
        /// <summary>
        /// Base class for example
        /// </summary>
        public class ScopeAndAccessibility
        {
            #region Public Fields

            public int publicField;

            #endregion

            #region Private Fields

            private int privateField;

            #endregion

            #region Protected Fields

            protected int protectedField;

            #endregion

            #region Internal Fields

            internal int internalField;

            #endregion

            #region Protected Internal Fields

            protected internal int protectedInternalField;

            #endregion

            #region Public Methods

            /// <summary>
            /// A public method. Accessible from anywhere.
            /// </summary>
            /// <exception cref="Exception">Throws an exception if a field cannot be accessed.</exception>
            public void PublicMethod()
            {
                // Access all fields within the class.
                Console.WriteLine("PublicField: " + publicField);
                Console.WriteLine("PrivateField: " + privateField);
                Console.WriteLine("ProtectedField: " + protectedField);
                Console.WriteLine("InternalField: " + internalField);
                Console.WriteLine("ProtectedInternalField: " + protectedInternalField);
            }

            #endregion

            #region Private Methods

            /// <summary>
            /// A private method. Accessible only within the class.
            /// </summary>
            private void PrivateMethod()
            {
                // Access all fields within the class.
                Console.WriteLine("PrivateField: " + privateField);
            }

            #endregion

            #region Protected Methods

            /// <summary>
            /// A protected method. Accessible within the class and derived classes.
            /// </summary>
            protected void ProtectedMethod()
            {
                // Access all fields within the class.
                Console.WriteLine("ProtectedField: " + protectedField);
            }

            #endregion

            #region Internal Methods

            /// <summary>
            /// An internal method. Accessible within the same assembly.
            /// </summary>
            internal void InternalMethod()
            {
                // Access all fields within the class.
                Console.WriteLine("InternalField: " + internalField);
            }

            #endregion

            #region Protected Internal Methods

            /// <summary>
            /// A protected internal method. Accessible within the same assembly or derived classes.
            /// </summary>
            protected internal void ProtectedInternalMethod()
            {
                // Access all fields within the class.
                Console.WriteLine("ProtectedInternalField: " + protectedInternalField);
            }

            #endregion
        }

        #endregion

        #region Public Classes (Derived)

        /// <summary>
        /// A derived class of ScopeAndAccessibility.
        /// </summary>
        public class DerivedClass : ScopeAndAccessibility
        {
            #region Public Methods

            /// <summary>
            /// A method in the derived class to demonstrate access to inherited fields and methods.
            /// </summary>
            public void DerivedMethod()
            {
                /// Access inherited fields and methods.
                Console.WriteLine("publicField: " + publicField);
                // Console.WriteLine("privateField: " + privateField); // Not accessible
                Console.WriteLine("protectedField: " + protectedField);
                Console.WriteLine("internalField: " + internalField);
                Console.WriteLine("protectedInternalField: " + protectedInternalField);

                /// Call inherited methods.
                PublicMethod();
                // PrivateMethod(); // Not accessible
                ProtectedMethod();
                InternalMethod();
                ProtectedInternalMethod();
            }

            #endregion
        }

        #endregion
    }
}
