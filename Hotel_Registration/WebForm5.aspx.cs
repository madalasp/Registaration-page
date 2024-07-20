using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;
using System.Xml.Schema;

namespace Hotel_Registration
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Username = TextBox1.Text;
            string RoomType=string.Empty;
            string Amenities = string.Empty;
            int rent = 0, acost = 0,totalcost = 0;
            if(RadioButton1.Checked==true)
            {
                RoomType=RadioButton1.Text;
            }
            else if(RadioButton2.Checked==true)
            {
                RoomType=RadioButton2.Text;
            }
            if(CheckBox1.Checked==true)
            {
                Amenities=CheckBox1.Text;
            }
            if(CheckBox2.Checked==true)
            {
                Amenities = CheckBox2.Text;
            }
            if(RadioButton1.Checked==true)
            {
                rent = 1000;
            }
            else if(RadioButton2.Checked==true)
            {
                rent = 500;
            }
            if(CheckBox1.Checked==true)
            {
                acost = 300;
            }
            if(CheckBox2.Checked==true)
            {
                acost = acost + 200;
            }
            totalcost = rent + acost;
            SqlConnection con = new SqlConnection("data source=SP;database=employee;Integrated Security=yes;");
            con.Open();
            string query="insert into Hot values('"+Username+"','"+RoomType+"','"+Amenities+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("WebForm6.aspx");
        }
    }
}