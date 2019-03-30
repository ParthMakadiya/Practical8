using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
           ((Site1)Master).buttonsearch.Click+=new EventHandler(buttonsearch_Click);                
        }
        void buttonsearch_Click(object sender, EventArgs e)
        {
            getData();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        void getData()
        {
            string source = @"Data Source=CE3COMP3\sqlexpress;Initial Catalog=DBstudent;Integrated Security=True;Pooling=False";
            string select = "select * from Tbl1";
            SqlConnection conn = new SqlConnection(source);
            SqlCommand cmd = new  SqlCommand(select,conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            getdetails.DataSource = reader;
            getdetails.DataBind();
            conn.Close();
        }

    }
}