using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Matab
{
    public partial class FrmListVisit : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        public FrmListVisit()
        {
            InitializeComponent();
        }
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectVisit", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGVisit.DataSource = dt;
        }
        private void FrmListVisit_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txtNameK_TextChanged(object sender, EventArgs e)
        {
            if (txtNameK.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchVisitWNameK", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@namek", txtNameK.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGVisit.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void txtIDVisit_TextChanged(object sender, EventArgs e)
        {
            if (txtIDVisit.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SelectVisitWID", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idvisit", txtIDVisit.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGVisit.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaskDateV1.Text) && string.IsNullOrWhiteSpace(MaskDateV2.Text))
            {
                MessageBox.Show("تاریخ وارد نشده است");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("ReportPayV", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Date1", MaskDateV1.Text);
                da.SelectCommand.Parameters.AddWithValue("@Date2", MaskDateV2.Text);
                DataTable ReportPayV = new DataTable();
                da.Fill(ReportPayV);
                DataGVisit.DataSource = ReportPayV;
                if (ReportPayV.Rows.Count == 0)
                {
                    MessageBox.Show("برای این تاریخ ها هیچ ویزیتی ثبت نشده است");
                }
                else
                {
                    Display();
                }
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaskDateV1.Text) && string.IsNullOrWhiteSpace(MaskDateV2.Text))
            {
                MessageBox.Show("تاریخ وارد نشده است");
            }
            else
            {
                Display();
                int sum = 0;
                for (int i = 0; i < DataGVisit.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(DataGVisit.Rows[i].Cells[8].Value);
                    LblPayV.Text = sum.ToString("###,###,###,###,###");
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            StiVisit.Load("ReportPayV.mrt");
            StiVisit.Compile();
            StiVisit["StrDate1"] = MaskDateV1.Text;
            StiVisit["StrDate2"] = MaskDateV2.Text;
            StiVisit["StrPay"] = LblPayV.Text;
            StiVisit.Show();
        }
    }
}
