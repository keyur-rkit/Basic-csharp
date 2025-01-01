using System;
using System.Data;

namespace Basic
{
    /// <summary>
    /// Demonstrates the use of DataTable in C#.
    /// </summary>
    public class DataTables
    {
        #region Public Methods

        /// <summary>
        /// Entry point to demonstrate DataTable usage.
        /// </summary>
        public static void RunDataTablesDemo()
        {
            Console.WriteLine("DataTable Operations\n");

            // Creating and setting up a DataTable
            DataTable studentTable = CreateStudentTable();
            AddStudentRows(studentTable);

            // Display the original DataTable
            DisplayDataTable(studentTable);

            // Apply advanced operations
            FilterAndSortDataTable(studentTable);
            CloneAndCopyDataTable(studentTable);
            AddComputedColumn(studentTable);
            DeleteRows(studentTable);

            // Demonstrate merging
            DataTable additionalTable = CreateStudentTable();
            AddStudentRows(additionalTable);
            MergeDataTables(studentTable, additionalTable);

            // Find a specific row
            FindRowByPrimaryKey(studentTable, 3);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Creates and configures a DataTable for student records.
        /// </summary>
        /// <returns>A configured DataTable.</returns>
        static DataTable CreateStudentTable()
        {
            DataTable table = new DataTable("Students");

            // Adding the ID column with AutoIncrement and Primary Key
            DataColumn idColumn = new DataColumn("ID", typeof(int))
            {
                AutoIncrement = true,
                AutoIncrementSeed = 100,
                AutoIncrementStep = 2
            };
            table.Columns.Add(idColumn);
            table.PrimaryKey = new DataColumn[] { idColumn };

            // Adding other columns
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Grade", typeof(string));

            Console.WriteLine("DataTable 'Students' created with columns: ID (AutoIncrement), Name, Age, Grade\n");
            return table;
        }

        /// <summary>
        /// Adds sample student records to the DataTable.
        /// </summary>
        /// <param name="table">The DataTable to add rows to.</param>
        static void AddStudentRows(DataTable table)
        {
            table.Rows.Add(null, "Keyur", 20, "A");
            table.Rows.Add(null, "Hit", 21, "B");
            table.Rows.Add(null, "Meet", 19, "A");
            table.Rows.Add(null, "Drashti", 22, "C");

            Console.WriteLine("Sample student records added to the DataTable.\n");
        }

        /// <summary>
        /// Displays the content of the DataTable.
        /// </summary>
        /// <param name="table">The DataTable to display.</param>
        static void DisplayDataTable(DataTable table)
        {
            Console.WriteLine("Displaying DataTable content:\n");

            foreach (DataColumn column in table.Columns)
            {
                Console.Write($"{column.ColumnName}\t");
            }
            Console.WriteLine();

            foreach (DataRow row in table.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Filters and sorts rows in the DataTable.
        /// </summary>
        /// <param name="table">The DataTable to filter and sort.</param>
        static void FilterAndSortDataTable(DataTable table)
        {
            Console.WriteLine("Filtering rows where Age > 20 and sorting by Name:\n");

            DataRow[] filteredRows = table.Select("Age > 20", "Name ASC");

            foreach (DataRow row in filteredRows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Age: {row["Age"]}, Grade: {row["Grade"]}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Clones and copies the structure and data of the DataTable.
        /// </summary>
        /// <param name="table">The DataTable to clone and copy.</param>
        static void CloneAndCopyDataTable(DataTable table)
        {
            DataTable clonedTable = table.Clone(); // Copies the structure (columns)
            Console.WriteLine("Cloned DataTable structure (no data):");
            DisplayDataTable(clonedTable);

            DataTable copiedTable = table.Copy(); // Copies structure and data
            Console.WriteLine("Copied DataTable structure and data:");
            DisplayDataTable(copiedTable);
        }

        /// <summary>
        /// Adds a computed column to the DataTable.
        /// </summary>
        /// <param name="table">The DataTable to modify.</param>
        static void AddComputedColumn(DataTable table)
        {
            table.Columns.Add("IsAdult", typeof(bool), "Age >= 18");

            Console.WriteLine("DataTable with computed column 'IsAdult':");
            DisplayDataTable(table);
        }

        /// <summary>
        /// Deletes rows from the DataTable where the condition is met.
        /// </summary>
        /// <param name="table">The DataTable to modify.</param>
        static void DeleteRows(DataTable table)
        {
            foreach (DataRow row in table.Select("Age < 20"))
            {
                row.Delete();
            }

            Console.WriteLine("DataTable after deleting rows where Age < 20:");
            DisplayDataTable(table);
        }

        /// <summary>
        /// Merges another DataTable into the existing one.
        /// </summary>
        /// <param name="table1">The main DataTable.</param>
        /// <param name="table2">The DataTable to merge.</param>
        static void MergeDataTables(DataTable table1, DataTable table2)
        {
            table1.Merge(table2);
            Console.WriteLine("DataTable after merging:");
            DisplayDataTable(table1);
        }

        /// <summary>
        /// Finds a row in the DataTable by its primary key.
        /// </summary>
        /// <param name="table">The DataTable to search.</param>
        /// <param name="id">The primary key to find.</param>
        static void FindRowByPrimaryKey(DataTable table, int id)
        {

            DataRow foundRow = table.Rows.Find(id);
            if (foundRow != null)
            {
                Console.WriteLine($"Found row: ID = {foundRow["ID"]}, Name = {foundRow["Name"]}, Age = {foundRow["Age"]}, Grade = {foundRow["Grade"]}");
            }
            else
            {
                Console.WriteLine("Row not found.");
            }
        }

        #endregion
    }
}
