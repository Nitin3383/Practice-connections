using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Services;

namespace Practiceconnections.Ajax_call
{
    public class User
    {
        public string Username { get; set; }
        public string email { get; set; }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RRQ98VL\MSSQL;Initial Catalog=Ajaxcall;Integrated Security=True");
                //string constr = ConfigurationManager.ConnectionStrings["Connnection"].ConnectionString;
                // using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("Select * from table1", con))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }


     
        public static void user(
             User user)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RRQ98VL\MSSQL;Initial Catalog=Ajaxcall;Integrated Security=True");
            //using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("insert into table1 values(@username,@email", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }


    }

}