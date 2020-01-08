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
    public partial class search_donor : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Acer\documents\visual studio 2012\Projects\Blood Bank\Blood Bank\App_Data\Donors.mdf"";Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            Session["BloodGroup"] = ddlBloodGroup.SelectedItem.Text;
            Session["Hospitals"] = ddlhospital.SelectedItem.Text;
            
            Response.Redirect("~/Pages/Donor_list.aspx");

        }
    }
}