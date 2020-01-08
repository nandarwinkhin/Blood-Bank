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
    public partial class Donor_list : System.Web.UI.Page
    {
        string bloodGroup ;
        string hospital ;
        int hospitalID = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Acer\documents\visual studio 2012\Projects\Blood Bank\Blood Bank\App_Data\Donors.mdf"";Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            bloodGroup = Session["BloodGroup"].ToString();
            hospital = Session["Hospitals"].ToString();
            
            if(hospital.Equals("Monywa General Hospital"))
                hospitalID=1;
            if (hospital.Equals("Shwe Taw Win Hospital"))
                hospitalID = 2;
            if (hospital.Equals("Metta Oo Hospital"))
                hospitalID = 3;
            if (hospital.Equals("Zar Ni Htun Hospital"))
                hospitalID = 4;
            if (hospital.Equals("So Pyay Hospital"))
                hospitalID = 5;
            if (hospital.Equals("Phyusin Myintta Hospital"))
                hospitalID = 6;
            if (hospital.Equals("Ka Yu Nar Myint Moh"))
                hospitalID = 7;
            if (hospital.Equals("200Bedded Women and Children Hospital Monywa"))
                hospitalID = 8;
            
            //string qty2 = "select Date,Hospital from Donor_Donation where Hospital=@hospitalid";
            //SqlCommand cmd2 = new SqlCommand(qty2, conn);
            //cmd2.Parameters.AddWithValue("@hospitalid",hospitalID);

            //SqlDataAdapter da2=new SqlDataAdapter();
            //da2.SelectCommand=cmd2;
            //string donor="";
            //SqlDataReader rdr2 = da2.SelectCommand.ExecuteReader();
            //if (rdr2.HasRows)
            //{
            //    donor = rdr2[0].ToString();
            //}

            
            if (!IsPostBack)
            {
                string qty = "select Name,Gender,Phone,Email from Donors join Donors_Hospitals on Donors.Name=Donors_Hospitals.DonorsName where Donors.BloodGroup=@bloodgroup and Donors_Hospitals.HospitalsID=@hospital and Donors.BodyWeight=@weight";
                SqlCommand cmd = new SqlCommand(qty, conn);
                cmd.Parameters.AddWithValue("@bloodgroup", bloodGroup);
                cmd.Parameters.AddWithValue("@hospital", hospitalID);
                cmd.Parameters.AddWithValue("@weight", "Yes");
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }

                
                //conn.Close();
            }
            
        }

        //private void BindGrid()
        //{
            
            
        //}
    }
}