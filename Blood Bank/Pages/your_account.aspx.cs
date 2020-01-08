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
    public partial class your_account : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Acer\documents\visual studio 2012\Projects\Blood Bank\Blood Bank\App_Data\Donors.mdf"";Integrated Security=True");
        int id ;
        string email="" ;
        string oldname="";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = 0;
            if (Session["User_ID"] != null)
            {
                id = (int)Session["User_ID"];
            }
            if (!Session["Email"].ToString().Equals(""))
            {
                email = Session["Email"].ToString();
            }
            oldname = Session["UserName"].ToString();
            conn.Open();
            if (!IsPostBack)
            {
                Populate_MonthList();
                Populate_YearList();
                Populate_MonthList2();
                Populate_YearList2();

                //conn.Open();
                
                //sdr.Close();
                



                
                string qry = "select * from Donors where DonorID=@id or Email=@email";
                SqlCommand cmd2 = new SqlCommand(qry, conn);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@email", email);
                SqlDataReader sdr = cmd2.ExecuteReader();
                while (sdr.Read())
                {

                    if (sdr[5].ToString() != "")
                    {
                        DateTime lastDonation = DateTime.Parse(sdr[5].ToString());
                        DateTime today = DateTime.Today;
                        TimeSpan diff = today - lastDonation;
                        double days = diff.TotalDays;
                        if (days < 112)
                        {
                            double safedate = 112 - days;
                            string safeToDonate = "You are safe to donate blood after :";
                            lblsafeToDonate.Text = safeToDonate + safedate + " days";
                        }
                        else
                        {
                            lblsafeToDonate.Text = "You are safe to donate blood.";
                        }
                    }
                    

                    string ava = "True";
                    if (sdr[10].ToString() == ava)
                    {
                        chkavailable.Checked = true;
                        //txtRname.Text = "";
                        //txtRname.Text = sdr[10].ToString();
                    }
                    else
                    {
                        chkavailable.Checked = false;
                    }

                    txtRname.Text = "";
                    txtRname.Text = sdr[1].ToString();
                    oldname = sdr[1].ToString();

                    string gender = "";
                    gender = sdr[2].ToString();
                    rblRgender.SelectedValue = gender;

                    txtBloodGroup.Text = "";
                    txtBloodGroup.Text = sdr[3].ToString();

                    txtRDob.Text = "";
                    txtRDob.Text = sdr[4].ToString();

                    //txtRlastbdd.Text = sdr[5].ToString();

                    string weight = "";
                    weight = sdr[6].ToString();
                    rblRweight.SelectedValue = weight;

                    txtRemial.Text = "";
                    txtRemial.Text = sdr[7].ToString();

                    txtRphone.Text = "";
                    txtRphone.Text = sdr[8].ToString();

                    txtpass.Text = "";
                    txtpass.Text = sdr[9].ToString();

                }
                sdr.Close();
                
            }
            //donated_panel.Visible = false;

            
        }


        


        

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            
            //string qry = "update Donors set (Name=@name,Gender=@gender,BloodGroup=@bloodgroup,DOB=@dob,Bodyweight=@weight,Email=@email,Phone=@phone,Password=@pass,Available=@ava) where DonorID=@id";
            //SqlCommand cmd = new SqlCommand(qry, conn);

            //lbl_test.Text = name;
            //if (name != "")
            //{
            Boolean ava=true;
            if (chkavailable.Checked)
            {
                ava = true;
            }
            else
            {
                ava = false;
            }

            string name = txtRname.Text;
            

            string gender = rblRgender.SelectedValue.ToString();

            string blood_group = txtBloodGroup.Text;

            string dob = txtRDob.Text;

            string weight = rblRweight.SelectedValue.ToString();

            string email = txtRemial.Text;

            string phone = txtRphone.Text;

            string pass = txtpass.Text;

            string qry = "update Donors set Donors.Name=@name, Donors.Gender=@gender, Donors.BloodGroup=@bloodgroup, Donors.DOB=@dob, Donors.BodyWeight=@weight, Donors.Email=@email, Donors.Phone=@phone, Donors.Password=@pass, Donors.Available=@ava  where Donors.DonorID=@id or Donors.Email=@email";
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@bloodgroup", blood_group);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@weight", weight);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@ava", ava);
            cmd.ExecuteNonQuery();

            string qry2 = "update Donors_Hospitals set DonorsName=@name where DonorsName=@oldname";
            SqlCommand cmd2 = new SqlCommand(qry2, conn);
            cmd2.Parameters.AddWithValue("@name", name);
            cmd2.Parameters.AddWithValue("@oldname", oldname);
            cmd2.ExecuteNonQuery();

            Session["UserName"] = name;
            //}
            //if (Gender != "")
            //{
            //    string qry = "update Donors set Gender=@gender where DonorID=@id or Email=@email";
            //    SqlCommand cmd = new SqlCommand(qry, conn);
            //    cmd.Parameters.AddWithValue("@gender", Gender);
            //    cmd.Parameters.AddWithValue("@id", id);
            //    cmd.Parameters.AddWithValue("@email", email);
            //    cmd.ExecuteNonQuery();
            //}
            //if (BGroup != "")
            //{
            //    string qry = "update Donors set BloodGroup=@bloodgroup where DonorID=@id or Email=@email";
            //    SqlCommand cmd = new SqlCommand(qry, conn);
            //    cmd.Parameters.AddWithValue("@bloodgroup", BGroup);
            //    cmd.Parameters.AddWithValue("@id", id);
            //    cmd.Parameters.AddWithValue("@email", email);
            //    cmd.ExecuteNonQuery();
            //}
            //if (dob != "")
            // {
            //     string qry = "update Donors set DOB=@dob where DonorID=@id or Email=@email";
            //     SqlCommand cmd = new SqlCommand(qry, conn);
            //     cmd.Parameters.AddWithValue("@dob", dob);
            //     cmd.Parameters.AddWithValue("@id", id);
            //     cmd.Parameters.AddWithValue("@email", email);
            //     cmd.ExecuteNonQuery();
            // }
            ////if (lastBD != null)
            ////{
            ////    ds.Tables["Update"].Rows[4]["Last_BDDate"] = lastBD;
            ////}
            // if (weight != "")
            // {
            //     string qry = "update Donors set Bodyweight=@weight where DonorID=@id or Email=@email";
            //     SqlCommand cmd = new SqlCommand(qry, conn);
            //     cmd.Parameters.AddWithValue("@weight", weight);
            //     cmd.Parameters.AddWithValue("@id", id);
            //     cmd.Parameters.AddWithValue("@email", email);
            //     cmd.ExecuteNonQuery();
            //}
            // if (email != "")
            //{
            //    string qry = "update Donors set Email=@email where DonorID=@id or Email=@email";
            //    SqlCommand cmd = new SqlCommand(qry, conn);
            //    cmd.Parameters.AddWithValue("@email", email);
            //    cmd.Parameters.AddWithValue("@id", id);
                
            //    cmd.ExecuteNonQuery();
            //}
            //if (phone != "")
            //{
            //    string qry = "update Donors set Phone=@phone where DonorID=@id or Email=@email";
            //    SqlCommand cmd = new SqlCommand(qry, conn);
            //    cmd.Parameters.AddWithValue("@phone", phone);
            //    cmd.Parameters.AddWithValue("@id", id);
            //    cmd.Parameters.AddWithValue("@email", email);
            //    cmd.ExecuteNonQuery();
            //}
            //if (pass != "")
            //{
            //    string qry = "update Donors set Password=@pass where DonorID=@id or Email=@email";
            //    SqlCommand cmd = new SqlCommand(qry, conn);
            //    cmd.Parameters.AddWithValue("@pass", pass);
            //    cmd.Parameters.AddWithValue("@id", id);
            //    cmd.Parameters.AddWithValue("@email", email);
            //    cmd.ExecuteNonQuery();
            //}


            //string qry1 = "update Donors set Available=@ava where DonorID=@id or Email=@email";
            //SqlCommand cmd1 = new SqlCommand(qry1, conn);
            //cmd1.Parameters.AddWithValue("@ava", available);
            //cmd1.Parameters.AddWithValue("@id", id);
            //cmd1.Parameters.AddWithValue("@email", email);
            //cmd1.ExecuteNonQuery();


            lblUpdateInfo.Text = "Your information is updated!";
            lblUpdateInfo.Visible = true;
        }

        protected void donated_CheckedChanged(object sender, EventArgs e)
        {
            //if (donated.Checked)
            //{
                donated_panel.Visible = true;

            
        }

        protected void donated_date_SelectionChanged(object sender, EventArgs e)
        {
            txtdate.Text = donated_date.SelectedDate.ToShortDateString();
        }

        protected void donated_button_Click(object sender, EventArgs e)
        {
            string qry = "insert into Donor_Donation(DonorID,Date,Hospital) values(@donorid,@date,@hospital)";
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@donorid", id);
            string date = txtdate.Text;
            cmd.Parameters.AddWithValue("@date", date);
            string hospital = donated_hospital.SelectedValue;
            cmd.Parameters.AddWithValue("@hospital", hospital);
            cmd.ExecuteNonQuery();

            string qry2 = "update Donors set Last_BDDate=@lastdate where DonorID=@id or Email=@email";
            SqlCommand cmd1 = new SqlCommand(qry2, conn);
            cmd1.Parameters.AddWithValue("@lastdate", date);
            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Parameters.AddWithValue("@email", email);
            cmd1.ExecuteNonQuery();

            lblUpdateLastbdd.Text = "Congratulation for your blood donation!\nYour last blood donation is updated.";
            lblUpdateLastbdd.Visible = true;
        }

        Boolean available=true;
        protected void chkavailable_CheckedChanged(object sender, EventArgs e)
        {
            if(chkavailable.Checked)
            {
                available = true;
            }
            else
            {
                available = false;
            }
        }



        //For calendar Dob
        protected void Populate_MonthList()
        {
            //Add each month to the list
            var dtf = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
            for (int i = 1; i <= 12; i++)
                drpCalMonth.Items.Add(new ListItem(dtf.GetMonthName(i), i.ToString()));

            //Make the current month selected item in the list
            drpCalMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }


        protected void Populate_YearList()
        {
            //Year list can be changed by changing the lower and upper 
            //limits of the For statement    
            for (int intYear = DateTime.Now.Year - 100; intYear <= DateTime.Now.Year; intYear++)
            {
                drpCalYear.Items.Add(intYear.ToString());
            }

            //Make the current year selected item in the list
            drpCalYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
        }

        protected void Set_Calendar(object Sender, EventArgs e)
        {
            int year = int.Parse(drpCalYear.SelectedValue);
            int month = int.Parse(drpCalMonth.SelectedValue);
            CalendarDOB.TodaysDate = new DateTime(year, month, 1);
        }

        protected void donated_date_SelectionChanged1(object sender, EventArgs e)
        {
            txtdate.Text = donated_date.SelectedDate.ToShortDateString();
        }

        //for calendar lastbdd

        protected void Populate_MonthList2()
        {
            //Add each month to the list
            var dtf = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
            for (int i = 1; i <= 12; i++)
                DropDownList3.Items.Add(new ListItem(dtf.GetMonthName(i), i.ToString()));

            //Make the current month selected item in the list
            DropDownList3.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }


        protected void Populate_YearList2()
        {
            //Year list can be changed by changing the lower and upper 
            //limits of the For statement    
            for (int intYear = DateTime.Now.Year - 10; intYear <= DateTime.Now.Year; intYear++)
            {
                DropDownList4.Items.Add(intYear.ToString());
            }

            //Make the current year selected item in the list
            DropDownList4.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
        }

        protected void Set_Calendar2(object Sender, EventArgs e)
        {
            int year = int.Parse(DropDownList4.SelectedValue);
            int month = int.Parse(DropDownList3.SelectedValue);
            donated_date.TodaysDate = new DateTime(year, month, 1);
        }

        protected void CalendarDOB_SelectionChanged(object sender, EventArgs e)
        {
            txtRDob.Text = CalendarDOB.SelectedDate.ToShortDateString();
        }

        //string name="";
        //protected void txtRname_TextChanged1(object sender, EventArgs e)
        //{
        //    name = txtRname.Text;
        //}  

        ////string lastBD;
        ////protected void txtRlastbdd_TextChanged(object sender, EventArgs e)
        ////{
        ////    lastBD = txtRlastbdd.Text;
        ////}

        //string Gender = "";
        //protected void rblRgender_SelectedIndexChanged1(object sender, EventArgs e)
        //{
        //    Gender = rblRgender.Text;
        //}

        //string BGroup = "";
        //protected void txtBloodGroup_TextChanged1(object sender, EventArgs e)
        //{
        //    if (txtBloodGroup.Text.Equals("O+") || txtBloodGroup.Text.Equals("O-") || txtBloodGroup.Text.Equals("A-") || txtBloodGroup.Text.Equals("A+") || txtBloodGroup.Text.Equals("B+") || txtBloodGroup.Text.Equals("B-") || txtBloodGroup.Text.Equals("AB-") || txtBloodGroup.Text.Equals("AB+"))
        //    {
        //        Response.Write("Blood group is incorrect!!");
        //    }
        //    else
        //    {
        //        BGroup = txtBloodGroup.Text;
        //    }
        //}

        //string dob = "";
        //protected void txtRDob_TextChanged1(object sender, EventArgs e)
        //{
        //    dob = txtRDob.Text;
        //}

        //string weight = "";
        //protected void rblRweight_SelectedIndexChanged1(object sender, EventArgs e)
        //{
        //    weight = rblRweight.Text;
        //}

        ////email = "";
        //protected void txtRemial_TextChanged(object sender, EventArgs e)
        //{
        //    email = txtRemial.Text;
        //}

        //string phone = "";
        //protected void txtRphone_TextChanged1(object sender, EventArgs e)
        //{
        //    phone = txtRphone.Text;
        //}

        //string pass = "";
        //protected void txtpass_TextChanged1(object sender, EventArgs e)
        //{
        //    pass = txtpass.Text;
        //}

       
    }
}