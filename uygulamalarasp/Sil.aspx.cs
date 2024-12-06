using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace uygulamalarasp
{
    public partial class Sil : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=MURATMEB\\SQLEXPRESS;Initial Catalog=ornek;Integrated Security=True;TrustServerCertificate=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelen =Convert.ToInt16(Request.QueryString["Id"]);
            try
            {
                conn.Open();
                string sorgu = "Delete from Admin where Id='" + gelen+"'";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
                // Response.Write("Kayıt Silindi");
                Response.Write("<script>alert('Kayıt Silindi'); window.location.href='Ekle.aspx'</script>");
                //Response.Redirect("Ekle.aspx");
                conn.Close();
            }
            catch (Exception ex)
            {

                Response.Write("Hata Oluştu" + ex.Message);
            }
        }
    }
}