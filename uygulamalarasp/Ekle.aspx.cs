using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace uygulamalarasp
{
    public partial class Ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            doldur();
        }
        SqlConnection conn = new SqlConnection("Data Source=MURATMEB\\SQLEXPRESS;Initial Catalog=ornek;Integrated Security=True;TrustServerCertificate=True");
            
        private void doldur()
        {
            string sorgu = "Select * from Admin";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
            DataTable dt=new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sorgu = "insert into Admin(kuser,kpass) values (@kuser,@kpass)";
                SqlCommand cmd=new SqlCommand(sorgu, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@kuser", TextBox1.Text);
                cmd.Parameters.AddWithValue("@kpass", TextBox2.Text);
                cmd.ExecuteNonQuery();
                Response.Write("İşlem Başarılı");
                conn.Close();
                doldur();

            }
            catch (Exception ex)
            {

                Response.Write("Hata Oluştu" + ex.Message);
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from Admin where kuser like @ara";
            SqlCommand cmd = new SqlCommand(sorgu, conn);

            // Clear any previous parameters
            cmd.Parameters.Clear();

            // Add the parameter with the wildcard characters included in the value
            cmd.Parameters.AddWithValue("@ara", "%" + TextBox3.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Bind the data to the GridView
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}