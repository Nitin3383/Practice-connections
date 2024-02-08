using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

using System.Data;

namespace Practiceconnections.disconnectedapproach
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from table1",con);


                //----using datatable-------

                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //The following things are done by the Fill method
                //1. Open the connection
                //2. Execute Command
                //3. Retrieve the Result
                //4. Fill/Store the Retrieve Result in the Data table
                //5. Close the connection
                //MessageBox.Show("done");
                //foreach(DataRow row in dt.Rows)
                //{
                //    MessageBox.Show("Show successfullly done");
                //}


                //-----Using DataSet------
                //DataSet ds = new DataSet();
                //da.Fill(ds, "table1");

                //foreach (DataRow row in ds.Tables["student"].Rows)
                //{

                //}

            }
        }
    }
}