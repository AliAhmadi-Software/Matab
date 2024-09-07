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
    public partial class FrmPaylist : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int ID = 0;
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectPay", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGPay.DataSource = dt;
        }
        public FrmPaylist()
        {
            InitializeComponent();
        }

        private void FrmPaylist_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txtNameK_TextChanged(object sender, EventArgs e)
        {
            if (txtNameK.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchPayWName", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@name", txtNameK.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGPay.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void txtCodeMonshi_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeMonshi.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchPayWID", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@ID", txtCodeMonshi.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGPay.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void MaskSalary_TextChanged(object sender, EventArgs e)
        {
            if (MaskSalary.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchPayWDateS", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@DateS", MaskSalary.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGPay.DataSource = dt;
            }
            else
            {
                Display();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("ReportPay", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Date1", MaskDate1.Text);
            da.SelectCommand.Parameters.AddWithValue("@Date2", MaskDate2.Text);
            DataTable ReportPay = new DataTable();
            da.Fill(ReportPay);
            if (ReportPay.Rows.Count == 0)
            {
                MessageBox.Show("برای چاپ باید تاریخ ها را وارد نمایید");
            }
            else
            {
                StiReportPay.Load("ReportPay.mrt");
                StiReportPay.RegData(ReportPay);
                StiReportPay.Show();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaskDate1.Text) && string.IsNullOrWhiteSpace(MaskDate2.Text))
            {
                MessageBox.Show("تاریخ وارد نشده است");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("ReportPay", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Date1", MaskDate1.Text);
                da.SelectCommand.Parameters.AddWithValue("@Date2", MaskDate2.Text);
                DataTable ReportPay = new DataTable();
                da.Fill(ReportPay);
                DataGPay.DataSource = ReportPay;
                if (ReportPay.Rows.Count == 0)
                {
                    MessageBox.Show("برای این تاریخ ها هیچ پرداختی ثبت نشده است");
                }
                else
                {
                    Display();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(DataGPay.CurrentRow.Cells["idpay"].Value);
            if (MessageBox.Show("آیا می خواهید پرداخت انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeletePay", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpay", ID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف پرداخت با موفقیت انجام شد");
                //***************
                Display();
            }
        }
    }
}
