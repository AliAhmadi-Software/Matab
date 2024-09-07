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
    public partial class FrmInsurance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int CodeIn = 0;
        static PersianCalendar p = new PersianCalendar();
        string MyDate = p.GetYear(DateTime.Now).ToString("0000/") + p.GetMonth(DateTime.Now).ToString("00/") + p.GetDayOfMonth(DateTime.Now).ToString("00");
        public FrmInsurance()
        {
            InitializeComponent();
        }

        public void ClearT()
        {
            txtCodeIn.ResetText();
            txtNameIn.ResetText();
            txtPriceIn.ResetText();
            txtTozih.ResetText();
            txtCodeIn.Focus();
        }
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectInsurance", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGInsurance.DataSource = dt;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeIn.Text))
            {
                errorProvider1.SetError(txtCodeIn, "کد بیمه را وارد نمایید");
                txtCodeIn.Focus();
            }
            else
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Insurance where CodeIn=@codein";
                cmd.Parameters.AddWithValue("@codein", txtCodeIn.Text.Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodeIn.Text = dr["CodeIn"].ToString();
                    txtNameIn.Text = dr["NameIn"].ToString();
                    txtPriceIn.Text = dr["PriceIn"].ToString();
                    txtTozih.Text = dr["Tozih"].ToString();
                }
                else
                {
                    txtCodeIn.ResetText();
                    MessageBox.Show("بیمه ای با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeIn.Text))
            {
                errorProvider1.SetError(txtCodeIn, "کد بیمه وارد نشده است");
            }
            else if (string.IsNullOrWhiteSpace(txtNameIn.Text))
            {
                errorProvider1.SetError(txtNameIn, "نام بیمه وارد نشده است");
            }
            else if (string.IsNullOrWhiteSpace(txtPriceIn.Text))
            {
                errorProvider1.SetError(txtPriceIn, "تعرفه بیمه وارد نشده است");
            }
            else if (string.IsNullOrWhiteSpace(txtTozih.Text))
            {
                errorProvider1.SetError(txtTozih, "توضیحات بیمه وارد نشده است");
            }
            else
            {
                if (MessageBox.Show("آیا میخواهید بیمه جدیدی مشخصات ثبت نمایید؟") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddInsurance", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codein", txtCodeIn.Text.Trim());
                    cmd.Parameters.AddWithValue("@namein", txtNameIn.Text.Trim());
                    cmd.Parameters.AddWithValue("@pricein", txtPriceIn.Text.Trim());
                    cmd.Parameters.AddWithValue("@tozih", txtTozih.Text.Trim());
                    cmd.Parameters.Add("@result", SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                    if (res == 1)
                    {
                        MessageBox.Show("قبلا بیمه ای با این کد ثبت شده است", "خطا");
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("بیمه با موفقیت ثبت شد", "ثبت");
                        ClearT();
                        Display();
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CodeIn = Convert.ToInt32(txtCodeIn.Text);
            if (string.IsNullOrWhiteSpace(txtCodeIn.Text))
            {
                errorProvider1.SetError(txtCodeIn, "کد بیمه را وارد نمایید");
            }
            else if (MessageBox.Show("آیا می خواهید بیمه انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteInsurance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codein", CodeIn);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف بیمه با موفقیت انجام شد");
                //********************
                ClearT();
                Display();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CodeIn = Convert.ToInt32(txtCodeIn.Text);
            if (string.IsNullOrWhiteSpace(txtCodeIn.Text))
            {
                errorProvider1.SetError(txtCodeIn, "کد بیمه وارد نشده است");
            }
            else if (MessageBox.Show("آیا می خواهید این بیمه را ویرایش کنید ؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("EditInsurance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codein", txtCodeIn.Text.Trim());
                cmd.Parameters.AddWithValue("@namein", txtNameIn.Text.Trim());
                cmd.Parameters.AddWithValue("@pricein", txtPriceIn.Text.Trim());
                cmd.Parameters.AddWithValue("@tozih", txtTozih.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش بیمه با موفقیت انجام شد");
                //********************
                ClearT();
                Display();
            }
        }

        private void FrmInsurance_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void DataGInsurance_MouseUp(object sender, MouseEventArgs e)
        {
            txtCodeIn.Text = DataGInsurance[0, DataGInsurance.CurrentRow.Index].Value.ToString();
            txtNameIn.Text = DataGInsurance[1, DataGInsurance.CurrentRow.Index].Value.ToString();
            txtPriceIn.Text = DataGInsurance[2, DataGInsurance.CurrentRow.Index].Value.ToString();
            txtTozih.Text = DataGInsurance[3, DataGInsurance.CurrentRow.Index].Value.ToString();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            DataTable DateT = new DataTable();
            DateT.Columns.Add("DateT");
            DateT.Rows.Add();
            DateT.Rows[0]["DateT"] = MyDate;
            //*******************************************//
            SqlDataAdapter da = new SqlDataAdapter("SelectInsurance", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable ReportInsurance = new DataTable();
            da.Fill(ReportInsurance);
            //
            DataSet ds = new DataSet();
            ds.Merge(DateT);
            ds.Tables[0].TableName = "DateT";
            ds.Merge(ReportInsurance);
            ds.Tables[1].TableName = "ReportInsurance";
            //
            StiReportInsurance.Load("ReportInsurance.mrt");
            StiReportInsurance.RegData(ds);
            StiReportInsurance.Show();
        }
    }
}
