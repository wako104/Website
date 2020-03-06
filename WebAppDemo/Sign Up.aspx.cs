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

        protected void FnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UsernameTb_TextChanged(object sender, EventArgs e)
        {

        }

        protected void EmailTb_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string Fname = FnameTb.Text;
            string Lname = LnameTb.Text;
            string Username = UsernameTb.Text;
            string Email = EmailTb.Text;
            string Password = PasswordTb.Text;

            OleDbConnection con = new OleDbConnection();

            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\wcfs5\home\William.Wakeford\Computer Science\NEA PROJECT\Database\Database3.accdb";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO User (UserName, FirstName, LastName, Email, Password) VALUES (@uname, @fname, @lname, @email, @password)";


            if(con.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@uname", OleDbType.VarChar).Value = Username;
                cmd.Parameters.Add("@fname", OleDbType.VarChar).Value = Fname;
                cmd.Parameters.Add("@lname", OleDbType.VarChar).Value = Lname;
                cmd.Parameters.Add("@email", OleDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@password", OleDbType.VarChar).Value = Password;
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
            }

        }


    }
}