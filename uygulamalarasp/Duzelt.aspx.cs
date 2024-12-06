using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace uygulamalarasp
{
    public partial class Duzelt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack==false)
            {
                int gelen = Convert.ToInt16(Request.QueryString["Id"]);
                string sorgu = "Select * from Admin where Id='" + gelen + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox3.Text = dr[0].ToString();

                }

                conn.Close();
            }
           

        }
        SqlConnection conn = new SqlConnection("Data Source=MURATMEB\\SQLEXPRESS;Initial Catalog=ornek;Integrated Security=True;TrustServerCertificate=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
           
                conn.Open();
                string sorgu = "Update Admin set kuser=@kuser,kpass=@kpass where Id=@Id";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@kuser", TextBox1.Text);
                cmd.Parameters.AddWithValue("@kpass", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Id", TextBox3.Text);
                cmd.ExecuteNonQuery();
                Response.Write("İşlem Başarılı");
                conn.Close();
          
            
        }
    }
}