using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hotel_Registration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string FirstName = TextBox1.Text;
            string SureName = TextBox2.Text;
            int Age=Convert.ToInt32(TextBox3.Text);
            string Gender = string.Empty;
            string Email=TextBox5.Text;
            string PhoneNumber = TextBox6.Text;
            string Adress=TextBox7.Text;
            string Language=string.Empty;
            string UserName=TextBox9.Text;
            string Password=TextBox10.Text;
            if (RadioButton1.Checked==true)
            {
                Gender=RadioButton1.Text;
            }
            else if(RadioButton2.Checked==true)
            {
                Gender=RadioButton2.Text;
            }
            if(CheckBox1.Checked==true)
            {
                Language=Language+CheckBox1.Text;
            }
            if (CheckBox2.Checked == true) 
            { 
            Language=Language+CheckBox2.Text;
            }
            if(CheckBox3.Checked==true)
            {
                Language = Language+CheckBox3.Text;
            }
            if(CheckBox4.Checked==true)
            {
                Language=Language+CheckBox4.Text;
            }
            var Country=DropDownList1.SelectedValue;
            SqlConnection con = new SqlConnection("data Source=SP;database=employee;Integrated Security=yes;");
            //open connection 
            con .Open();
            //pass Query
            string query = "insert into Cust values('" + FirstName + "','" + SureName + "','" + Age + "','" + Gender + "','" + Email + "','" + PhoneNumber + "','" + Adress + "','" + Country + "','" + Language + "','" + UserName + "','" + Password + "')";
            SqlCommand cmd = new SqlCommand(query,con);
           //execute nonQuery
           cmd.ExecuteNonQuery();
            //close connection
            con.Close();
            Console.WriteLine("Registration Complete");
            Response.Redirect("WebForm2.aspx");
        }
    }
}