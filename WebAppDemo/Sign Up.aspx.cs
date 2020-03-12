using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace WebAppDemo
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            static int UpdateInsertDeleteRecordsOnDatabase(string connString, string sqlString)
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



            string connString = "Provider = Microsoft.ACE.OLEDB.12.0;Data source= n:\\Database3.accdb";
            string sql = "Insert User Set UserName = '" + UsernameTb.Text + "', FirstName = '" + FnameTb.Text + "', LastName = '" + LnameTb.Text + "', Email = '" + EmailTb.Text + "', Password = '" + PasswordTb.Text + "'";

            int Result = UpdateInsertDeleteRecordsOnDatabase(connString, sql);
            if (Result > 0)
            {
                lblMessage.Text = "The update was successful";
            }
            else
            {
                lblMessage.Text = "Record could not be updated - try again";
            }

            /*OleDbConnection con = new OleDbConnection();

            OleDbCommand cmd = new OleDbCommand("Insert into [User] (UserName, FirstName, LastName, Email, Password) VALUES (@uname, @fname, @lname, @email, @password)", con);
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\wcfs5\home\William.Wakeford\Computer Science\NEA PROJECT\Database\Database3.accdb";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Insert into [User] (UserName, FirstName, LastName, Email, Password) VALUES (@uname, @fname, @lname, @email, @password)";


            if(con.State == ConnectionState.Open)
            {
                cmd.Parameters.AddWithValue("@uname", UsernameTb.Text);
                cmd.Parameters.AddWithValue("@fname", FnameTb.Text);
                cmd.Parameters.AddWithValue("@lname", LnameTb.Text);
                cmd.Parameters.AddWithValue("@email", EmailTb.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTb.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('sign up successful');</script>");
                    con.Close();
                }
                catch(OleDbException ex)
                {
                    Response.Write("<script>alert('sign up unsuccessful');</script>");
                    con.Close();
                }
            }
            else
            {
                Response.Write("<script>alert('Connection failed');</script>");
            }*/

        }

        protected void FnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}