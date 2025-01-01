using System;

namespace Basic
{
    /// <summary>
    /// Class to demonstrate basic c#
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point of project
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice : ");
            Console.WriteLine("1. HelloWorld");
            Console.WriteLine("2. Datatypes");
            Console.WriteLine("3. Operators");
            Console.WriteLine("4. Statements");
            Console.WriteLine("5. Arrays");
            Console.WriteLine("6. Methods");
            Console.WriteLine("7. Classes");
            Console.WriteLine("8. Inheritance");
            Console.WriteLine("9. Encapsulation");
            Console.WriteLine("10. Polymorphism");
            Console.WriteLine("11. Abstraction");
            Console.WriteLine("12. Multiple Inheritance");
            Console.WriteLine("13. Scope and Access Modifier");
            Console.WriteLine("14. Namespace");
            Console.WriteLine("15. Reference");
            Console.WriteLine("16. Collections");
            Console.WriteLine("17. Enumerations");
            Console.WriteLine("18. DataTables");
            Console.WriteLine("19. Exception Handling");
            Console.WriteLine("20. String Class");
            Console.WriteLine("21. Date Time CLass");
            Console.WriteLine("22. File Operations");
            Console.WriteLine("23. StreamReader and StreamWriter Class");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    HelloWorld.RunHelloWorld();
                    break;

                case 2:
                    Datatypes.RunDatatypeDemo();
                    break;

                case 3:
                    Operators.RunOperatorsDemo();
                    break;

                case 4:
                    Statements.RunStatementsDemo();
                    break;

                case 5:
                    Arrays.RunArraysDemo();
                    break;

                case 6:
                    Methods.RunMethodsDemo();
                    break;

                case 7:
                    Classes.RunClassesDemo();
                    break;

                case 8:
                    Inheritance.RunInheritanceDemo();
                    break;

                case 9:
                    Encapsulation.RunEncapsulationDemo();
                    break;

                case 10:
                    Polymorphism.RunPolymorphismDemo();
                    break;

                case 11:
                    Abstraction.RunAbstractionDemo();
                    break;

                case 12:
                    MultipleInheritance.RunMultipleInheritanceDemo();
                    break;

                case 13:
                    ScopeAndAccessModifier.RunScopeAndAccessModifierDemo();
                    break;

                case 14:
                    Namespace.RunNamespaceDemo();
                    break;

                case 15:
                    Reference.RunReferenceDemo();
                    break;

                case 16:
                    Collections.RunCollectionsDemo();
                    break;

                case 17:
                    Enumerations.RunEnumerationsDemo();
                    break;

                case 18:
                    DataTables.RunDataTablesDemo();
                    break;

                case 19:
                    ExceptionHandling.RunExceptionHandlingDemo();
                    break;

                case 20:
                    StringClass.RunStringClassDemo();
                    break;

                case 21:
                    DateTimeClass.RunDateTimeClassDemo();
                    break;

                case 22:
                    FileOperations.RunFileOperationsDemo();
                    break;

                case 23:
                    ReFileOperations.RunReFileOperations();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}