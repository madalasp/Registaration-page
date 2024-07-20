using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hotel_Registration
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string UserName = TextBox1.Text;
            string Password = TextBox2.Text;
            SqlConnection con = new SqlConnection("data source=SP;database=employee;Integrated Security=yes;");
            //open connection
            con.Open();
            //pass the query
            string query = "select password from Cust where UserName='" + UserName + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            Password = cmd.ExecuteScalar().ToString();
            if (Password == TextBox2.Text) 
            {
                Label3.Text = "valid cred";
            }
            else
            {
                Label3.Text = "invalid cred!!";
            }
            Response.Redirect("WebForm4.aspx");
        }
    }
}