using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikesystem
{
    // Class for handling database functions
    internal class Functions
    {
        private SqlConnection Con; // SQL connection object
        private SqlCommand Cmd;    // SQL command object
        private DataTable dt;      // Data table to store results
        private SqlDataAdapter Sda; // Data adapter for filling the data table
        private string ConStr;      // Connection string for the database

        // Constructor initializes the database connection
        public Functions()
        {
            // Connection string specifying the database location and credentials
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tekno\OneDrive\Belgeler\BikeDb.mdf;Integrated Security=True;Connect Timeout=30;";
            Con = new SqlConnection(ConStr); // Creating a new SqlConnection object
            Cmd = new SqlCommand();           // Creating a new SqlCommand object
            Cmd.Connection = Con;             // Assigning the connection to the command
        }

        // Method to retrieve data from the database
        public DataTable GetData(string Query)
        {
            dt = new DataTable();                        // Creating a new DataTable to store results
            Sda = new SqlDataAdapter(Query, ConStr);    // Creating a SqlDataAdapter with the query and connection string
            Sda.Fill(dt);                               // Filling the DataTable with the query result
            return dt;                                  // Returning the filled DataTable
        }

        // Method to execute non-query commands on the database
        public int SetData(string Query)
        {
            int Cnt = 0;                                 // Counter for the number of affected rows
            if (Con.State == ConnectionState.Closed)    // Checking if the connection is closed
            {
                Con.Open();                              
            }
            Cmd.CommandText = Query;                    // Assigning the query to the command
            Cnt = Cmd.ExecuteNonQuery();               // Executing the non-query command and getting the affected rows count
            Con.Close();                                
            return Cnt;                                 // Returning the number of affected rows
        }
    }
}
