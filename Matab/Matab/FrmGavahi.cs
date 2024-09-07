using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Matab
{
    public partial class FrmGavahi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        public FrmGavahi()
        {
            InitializeComponent();
        }

        private void FrmGavahi_Load(object sender, EventArgs e)
        {
            PersianCalendar p = new PersianCalendar();
            maskDateG.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString() + p.GetDayOfMonth(DateTime.Now).ToString();
            //*********************************************
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select NameMatab,Tel from Info";
            con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            LblNameMatab.Text = dr["NameMatab"].ToString();
            LblTel.Text = dr["Tel"].ToString();
            con.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            StiReportG.Load("ReportG.mrt");
            StiReportG.Compile();
            StiReportG["StrSex"] = ComboSex.Text;
            StiReportG["StrName"] = txtName.Text;
            StiReportG["Strill"] = txtill.Text;
            StiReportG["StrDateG"] = maskDateG.Text;
            StiReportG["StrDays"] = txtDays.Text;
            StiReportG["StrL"] = txtL.Text;
            StiReportG["NameMatab"] = LblNameMatab.Text;
            StiReportG["Tel"] = LblTel.Text;
            StiReportG.Show();
        }
    }
}
