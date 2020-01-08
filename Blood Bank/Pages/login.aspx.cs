using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Blood_Bank.Pages
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Acer\documents\visual studio 2012\Projects\Blood Bank\Blood Bank\App_Data\Donors.mdf"";Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible=false;
        }
      
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string email_or_phone = txtLphoremail.Text;
           
            string pass = txtLpass.Text;

            string qry = "select * from Donors where (Email=@email or Phone=@phone) and Password=@pass";
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@email", email_or_phone);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@phone", email_or_phone);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Session["User_ID"] = Convert.ToInt32(sdr["DonorID"].ToString());
                
                Session["Email"] = sdr["Email"]; 
                //Session["Phone"] = txtLphoremail.Text;
                Session["Password"] = sdr["Password"];
                Session["UserName"] = sdr["Name"];
                Response.Redirect("~/Pages/LoginAfter.aspx");
              }
              else
              {
                 lblError.Text = "Email or Phone & Password Is not correct Try again..!!";
                 lblError.Visible = true;
                  
              }
              
           }

        protected void link_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/register.aspx");
        }
   
      }

 }
    
