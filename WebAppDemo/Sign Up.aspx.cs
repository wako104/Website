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
            try
            {
                DBAccess dbsignup = new DBAccess(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\wcfs5\home\William.Wakeford\Computer Science\NEA PROJECT\Database\Database3.accdb");

                string sql = "INSERT INTO User(UserName, FirstName, LastName, Email, [Password]";
                sql = sql + "VALUES('" + UsernameTb + "',  '" + FnameTb.Text + "','" + LnameTb.Text + "', '" + EmailTb.Text + "','" + PasswordTb + ", ";


                if (dbsignup.UpdateInsertDeleteRecordsOnDatabase(sql) == 1)
                {
                    Response.Write("<script>alert('sign up successful');</script>");
                }

                else
                {
                    Response.Write("<script>alert('sign up unsuccessful');</script>");
                }
            }

            catch
            {
                Response.Write("<script>alert('connection unsuccessful');</script>");

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