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
    public partial class Frm1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        static PersianCalendar p = new PersianCalendar();
        string MyDate = p.GetYear(DateTime.Now).ToString("0000/") + p.GetMonth(DateTime.Now).ToString("00/") + p.GetDayOfMonth(DateTime.Now).ToString("00");
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectNobat", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGNobat.DataSource = dt;
        }
        public Frm1()
        {
            InitializeComponent();
        }

        private void BtnKarbar_Click(object sender, EventArgs e)
        {
            FrmKarbar fkarbar = new FrmKarbar();
            fkarbar.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Display();
            LblDate.Text = MyDate;
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    LblDay.Text = "جمعه";
                    break;
                case DayOfWeek.Saturday:
                    LblDay.Text = "شنبه";
                    break;
                case DayOfWeek.Sunday:
                    LblDay.Text = "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    LblDay.Text = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    LblDay.Text = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    LblDay.Text = "چهار شنبه";
                    break;
                case DayOfWeek.Thursday:
                    LblDay.Text = "پنج شنبه";
                    break;
            }
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            FrmInfo finfo = new FrmInfo();
            finfo.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            FrmMonshi fmonshi = new FrmMonshi();
            fmonshi.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            FrmListMonshi flistMonshi = new FrmListMonshi();
            flistMonshi.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FrmPaylist fpay = new FrmPaylist();
            fpay.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            FrmNobat fnobat = new FrmNobat();
            fnobat.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchNobatWNamek", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@namek", txtName.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGNobat.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void txtNobat_TextChanged(object sender, EventArgs e)
        {
            if (txtNobat.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchNobatWN", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@nobat", txtNobat.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGNobat.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void MaskDateN_TextChanged(object sender, EventArgs e)
        {
            if (MaskDateN.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SelectNobatWDateN", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@daten", MaskDateN.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGNobat.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaskDateN.Text))
            {
                MessageBox.Show("ابتدا تاریخی را برای چاپ وارد نمایید");
            }
            else
            {
                DataTable DtDate = new DataTable();
                DtDate.Columns.Add("Date");
                DtDate.Rows.Add();
                DtDate.Rows[0]["Date"] = MyDate;
                //*******************************************//
                SqlDataAdapter da = new SqlDataAdapter("SelectNobatWDateN", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@daten", MaskDateN.Text);
                DataTable ReportNobat = new DataTable();
                da.Fill(ReportNobat);
                //
                DataSet ds = new DataSet();
                ds.Merge(DtDate);
                ds.Tables[0].TableName = "DtDate";
                ds.Merge(ReportNobat);
                ds.Tables[1].TableName = "ReportNobat";
                //
                StiNobat.Load("ReportNobat.mrt");
                StiNobat.RegData(ds);
                StiNobat.Show();
            }
        }

        private void BtnService_Click_1(object sender, EventArgs e)
        {
            FrmServiceMatab fService = new FrmServiceMatab();
            fService.ShowDialog();
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            FrmInsurance fIn = new FrmInsurance();
            fIn.ShowDialog();
        }

        private void buttonX4_Click_1(object sender, EventArgs e)
        {
            FrmBackup fbackup = new FrmBackup();
            fbackup.ShowDialog();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            FrmVisit fvisit = new FrmVisit();
            fvisit.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            FrmListVisit flistv = new FrmListVisit();
            flistv.ShowDialog();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            FrmFile ffile = new FrmFile();
            ffile.ShowDialog();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            FrmListFile flistf = new FrmListFile();
            flistf.ShowDialog();
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            FrmActivity factive = new FrmActivity();
            factive.ShowDialog();
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            FrmGavahi fg = new FrmGavahi();
            fg.ShowDialog();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            FrmCostMatab fcost = new FrmCostMatab();
            fcost.ShowDialog();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            FrmListCost flcost = new FrmListCost();
            flcost.ShowDialog();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
