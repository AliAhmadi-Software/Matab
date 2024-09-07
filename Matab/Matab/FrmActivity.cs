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
    public partial class FrmActivity : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        public FrmActivity()
        {
            InitializeComponent();
        }

        private void FrmActivity_Load(object sender, EventArgs e)
        {
            PersianCalendar p = new PersianCalendar();
            MaskDate2.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString() + p.GetDayOfMonth(DateTime.Now).ToString();
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

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcmd = new SqlCommand("CountV", con);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@Date1", MaskDate1.Text);
            sqlcmd.Parameters.AddWithValue("@Date2", MaskDate2.Text);
            con.Open();
            LblCountV.Text = "" + Convert.ToString((int)sqlcmd.ExecuteScalar()) + "";
            con.Close();
            //*******************************************************************************
            SqlCommand sqlcmd1 = new SqlCommand("SumIn", con);
            sqlcmd1.CommandType = CommandType.StoredProcedure;
            sqlcmd1.Parameters.AddWithValue("@Date1", MaskDate1.Text);
            sqlcmd1.Parameters.AddWithValue("@Date2", MaskDate2.Text);
            con.Open();
            LblSumIn.Text = "" + Convert.ToString((int)sqlcmd1.ExecuteScalar()) + "";
            con.Close();
            //*******************************************************************************
            SqlCommand sqlcmd2 = new SqlCommand("SumV", con);
            sqlcmd2.CommandType = CommandType.StoredProcedure;
            sqlcmd2.Parameters.AddWithValue("@Date1", MaskDate1.Text);
            sqlcmd2.Parameters.AddWithValue("@Date2", MaskDate2.Text);
            con.Open();
            LblSumV.Text = "" + Convert.ToString((int)sqlcmd2.ExecuteScalar()) + "";
            con.Close();
            //*******************************************************************************
            int a, b = 0;
            a = Convert.ToInt32(LblSumIn.Text);
            b = Convert.ToInt32(LblSumV.Text);
            LblSumT.Text = (a + b).ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            StiReportA.Load("ReportA.mrt");
            StiReportA.Compile();
            StiReportA["StrDate1"] = MaskDate1.Text;
            StiReportA["StrDate2"] = MaskDate2.Text;
            StiReportA["CountV"] = LblCountV.Text;
            StiReportA["SumIn"] = LblSumIn.Text;
            StiReportA["SumV"] = LblSumV.Text;
            StiReportA["SumT"] = LblSumT.Text;
            StiReportA["NameMatab"] = LblNameMatab.Text;
            StiReportA["Tel"] = LblTel.Text;
            StiReportA.Show();
        }
    }
}
