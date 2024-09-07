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
    public partial class FrmListCost : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        static PersianCalendar p = new PersianCalendar();
        string MyDate = p.GetYear(DateTime.Now).ToString("0000/") + p.GetMonth(DateTime.Now).ToString("00/") + p.GetDayOfMonth(DateTime.Now).ToString("00");
        public FrmListCost()
        {
            InitializeComponent();
        }
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectCostM", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGCost.DataSource = dt;
        }
        private void FrmListCost_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txtExplainC_TextChanged(object sender, EventArgs e)
        {
            if (txtExplainC.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SelectCostMWE", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@explain", txtExplainC.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGCost.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void txtCodeC_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeC.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SelectCostMWC", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@code", txtCodeC.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGCost.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DataTable DtDate = new DataTable();
            DtDate.Columns.Add("Date");
            DtDate.Rows.Add();
            DtDate.Rows[0]["Date"] = MyDate;
            //*******************************************//
            SqlDataAdapter da = new SqlDataAdapter("ReportCostM", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Date1", MaskDateC1.Text);
            da.SelectCommand.Parameters.AddWithValue("@Date2", MaskDateC2.Text);
            DataTable ReportNobat = new DataTable();
            da.Fill(ReportNobat);
            //
            DataSet ds = new DataSet();
            ds.Merge(DtDate);
            ds.Tables[0].TableName = "DtDate";
            ds.Merge(ReportNobat);
            ds.Tables[1].TableName = "ReportCostM";
            //
            StiReportC.Load("ReportCostM.mrt");
            StiReportC.RegData(ds);
            StiReportC.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaskDateC1.Text) && string.IsNullOrWhiteSpace(MaskDateC2.Text))
            {
                MessageBox.Show("تاریخ وارد نشده است");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("ReportCostM", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Date1", MaskDateC1.Text);
                da.SelectCommand.Parameters.AddWithValue("@Date2", MaskDateC2.Text);
                DataTable ReportCostM = new DataTable();
                da.Fill(ReportCostM);
                DataGCost.DataSource = ReportCostM;
                if (ReportCostM.Rows.Count == 0)
                {
                    MessageBox.Show("برای این تاریخ ها هیچ هزینه ای ثبت نشده است");
                }
                else
                {
                    Display();
                }
            }
        }
    }
}
