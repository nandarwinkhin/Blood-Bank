using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blood_Bank
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_ID"] != null || Session["Email"] != null)
            {
                lnkRegister.Text = Session["UserName"].ToString();
                lnkLogin.Visible = false;

                lnkLogout.Visible = true;
                link_your_acc.Visible = true;

                lnkRegister.Enabled = false;

                Label1.Visible = true;
            }
            else
            {
                lnkRegister.Enabled = true;

                lnkLogin.Visible = true;

                lnkLogout.Visible = false;

                Label1.Visible = false;
            }

        }
        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/Pages/login.aspx");
        }
    }
}