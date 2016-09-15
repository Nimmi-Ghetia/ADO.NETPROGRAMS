using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace PAPERSOLUTION
{
	public partial class Program_3b : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
           {
            String username = uname.Text;
            String password = pwd.Text;
            SqlConnection con = new SqlConnection("Data Source=CELAB5;Initial Catalog=master;Integrated Security=True");
            String query = "Select * from Login";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            Label3.Text = username + " ," + password;
            bool verify = false;
            while(rd.Read())
            {
                
                String s1=rd["Username"].ToString() ;
                String s2=rd["Password"].ToString() ;
                Label2.Text += s1 + "," + s2+"    " ;
                if (username.Equals(rd["Username"]) && password.Equals(rd["Password"]))
                {
                    verify = true;
                    break;
                }
            }
            if(verify==true)
            {
                Session["username"] = username;

                Response.Redirect("Display.aspx");
            }
            else
            {
                Label1.Text = "Wrong details.Try Again";    
            }
            con.Close();
        }
	}
}