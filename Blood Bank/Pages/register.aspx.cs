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
    public partial class register : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Acer\documents\visual studio 2012\Projects\Blood Bank\Blood Bank\App_Data\Donors.mdf"";Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Populate_MonthList();
                Populate_YearList();
                Populate_MonthList2();
                Populate_YearList2();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            conn.Open();
            string name = txtRname.Text; ;
            String qry = "insert into Donors(Name,Gender,BloodGroup,DOB,Last_BDDate,BodyWeight,Email,Phone,Password,Available) values(@name,@gender,@blood_group,@dob,@last_bdDate,@body_weight,@email,@phone,@password,@available)";
            
            SqlCommand cmd = new SqlCommand(qry,conn);
            

            cmd.Parameters.AddWithValue("@name", name);

            int available = 0;
            if (chkavailable.Checked)
            {
                available = 1;
            }
            else
            {
                available = 0;
            }
            cmd.Parameters.AddWithValue("@available", available);

            String gender = rblRgender.SelectedValue;
            cmd.Parameters.AddWithValue("@gender",gender);

            string blood_group = ddlRgroup.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@blood_group",blood_group);

            string dob=txtRDob.Text;
            cmd.Parameters.AddWithValue("@dob", dob);

            string last_bdDate = txtRlastbdd.Text;
            cmd.Parameters.AddWithValue("@last_bdDate", last_bdDate);

            if (hospital1.Checked)
            {
                string qry2 = "insert into Donors_Hospitals(DonorsName,HospitalsID) values('" + name + "',1)";
                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                cmd2.ExecuteNonQuery();
            }


            if (hospital2.Checked)
            {
                string qry2 = "insert into Donors_Hospitals(DonorsName,HospitalsID) values('" + name + "',2)";
                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                cmd2.ExecuteNonQuery();
            }


            if (hospital3.Checked)
            {
                string qry2 = "insert into Donors_Hospitals(DonorsName,HospitalsID) values('" + name + "',3)";
                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                cmd2.ExecuteNonQuery();
            }


            if (hospital4.Checked)
            {
                string qry2 = "insert into Donors_Hospitals(DonorsName,HospitalsID) values('" + name + "',4)";
                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                cmd2.ExecuteNonQuery();
            }
                

            if (hospital5.Checked)
            {
                string qry2 = "insert into Donors_Hospitals(DonorsName,HospitalsID) values('" + name + "',5)";
                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                cmd2.ExecuteNonQuery();
            }


            if (hospital6.Checked)
            {
                string qry2 = "insert into Donors_Hospitals(DonorsName,HospitalsID) values('" + name + "', 6)";
                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                cmd2.ExecuteNonQuery();
            }



            if (hospital7.Checked)
            {
                string qry2 = "insert into Donors_Hospitals(DonorsName,HospitalsID) values('" + name + "',7)";
                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                cmd2.ExecuteNonQuery();
            }


            if (hospital8.Checked)
            {
                string qry2 = "insert into Donors_Hospitals(DonorsName,HospitalsID) values('" + name + "',8)";
                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                cmd2.ExecuteNonQuery();
            }
               
            //cmd.Parameters.AddWithValue("@hospitals", hospitals);
            cmd.Parameters.AddWithValue("@body_weight", rblRweight.SelectedValue);
            cmd.Parameters.AddWithValue("@email", txtRemial.Text);
            cmd.Parameters.AddWithValue("@phone",txtRphone.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);
            cmd.ExecuteNonQuery();

            Session["Email"] = txtRemial.Text.ToString();
            Session["UserName"] = name;
           
            Response.Redirect("~/Pages/RegisterAfter.aspx");
            
        }

        protected void CalendarDOB_SelectionChanged(object sender, EventArgs e)
        {
            txtRDob.Text = CalendarDOB.SelectedDate.ToShortDateString();
        }

        protected void CalendarLastbdd_SelectionChanged(object sender, EventArgs e)
        {
            txtRlastbdd.Text = CalendarLastbdd.SelectedDate.ToShortDateString();
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
            for (int intYear = DateTime.Now.Year - 100; intYear <= DateTime.Now.Year ; intYear++)
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
            CalendarLastbdd.TodaysDate = new DateTime(year, month, 1);
        }


    }
}