using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace WebAppDemo
{
    public class DBAccess
    {         //using System.Data.OleDb; needed for this class 

        //Private attribute of the class to store the connection string.
        //Will be initialised when the constructor is called
        private string connString = "";

        //Class constructor
        public DBAccess(string connString)
        {
            //Assign the passed in string to the private attribute of the class connString
            //This string could be stored in the App.config (win form) or Web.config (web)
            //file of the project and referenced from there

            this.connString = connString;
        }

        //This method takes an sql statement and returns a 2d arrray to the calling procedure
        //which is populated with a data set that represents the results of the sql statement
        public string[,] GetRecordsFromDatabase(string sqlString)
        {
            //Creating a System.Data.OleDb.OleDbConnection connection object
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

            //Assigning connString to the ConnectionString attribute of the conn object 
            conn.ConnectionString = connString;

            //Calling the Open method of the conn object to open the database
            conn.Open();

            //Create an OleDbCommand object and pass an sql string and conn object to its constructor 
            OleDbCommand cmd = new OleDbCommand(sqlString, conn);

            //Send the CommandText to the connection, and then build an OleDbDataReader
            //This populates the reader object with the contents of the result of the executed sql
            OleDbDataReader reader = cmd.ExecuteReader();

            //Calling the FieldCount attribute of the reader object to get the number of 
            //columns/fields/attributes returned from the sql query
            int col_count = reader.FieldCount;

            //row_count will be used in the while loop to determine the number of records
            int row_count = 0;

            while (reader.Read())
            {
                //counting the number of rows/records returned
                row_count = row_count + 1;
            }
            reader.Close();

            //This 2 dimensional array is being initialised with the number of rows and columns
            //needed to store the results of the query
            string[,] records = new string[row_count, col_count];

            //Execute the sql again
            reader = cmd.ExecuteReader();
            int count = 0;

            //Loop through the reader and pupulate 2d array with the data set
            while (reader.Read())
            {
                for (int x = 0; x < col_count; x++)
                {
                    if (reader.IsDBNull(x) == false)
                        records[count, x] = reader.GetValue(x).ToString();
                    else
                        records[count, x] = "";
                }
                count++;
            }

            //close the reader and conn object
            reader.Close();
            conn.Close();

            //return the the 2d array to the calling procedure
            return records;
        }

        //This method takes an sql (insert, update, delete) statement that modifies a table
        //and returns the number of rows/records affected to the calling procedure
        public int UpdateInsertDeleteRecordsOnDatabase(string sqlString)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();

            conn.ConnectionString = connString;
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(sqlString, conn);

            //Execute the sql
            OleDbDataReader reader = cmd.ExecuteReader();

            int rowsAffected = 0;

            //Because this is an sql statement that modifies the table
            //we call the RecordsAffected of the reader object to determnine the number of
            //rows/records affected by the sql
            rowsAffected = reader.RecordsAffected;
            reader.Close();
            conn.Close();

            //Returning the number of records/rows affected by the sql statement
            return rowsAffected;
        }
    }
}