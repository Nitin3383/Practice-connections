using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace Practiceconnections.Connectioncheck
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // To pass the connection string ConnectionString = (@"Data Source=DESKTOP-RRQ98VL\MSSQL;Initial Catalog=Ajaxcall;Integrated Security=True");
            string ConnectionString=ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                //SqlCommand cmd = new SqlCommand("select * from table1",con);
                SqlCommand cmd = new SqlCommand("insert into table1 values('Rohit','nitin@34')",con);//To insert the data in db using c#
                con.Open();
                    int eff = cmd.ExecuteNonQuery();

                    if (eff == -1)
                    {
                        con.Close();
             
                     MessageBox.Show("Done");
                    }
                    else
                        con.Close();
                
             }
                
        }
    }
}