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
    public partial class FrmServiceMatab : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int CodeS = 0;
        static PersianCalendar p = new PersianCalendar();
        string MyDate = p.GetYear(DateTime.Now).ToString("0000/") + p.GetMonth(DateTime.Now).ToString("00/") + p.GetDayOfMonth(DateTime.Now).ToString("00");
        public FrmServiceMatab()
        {
            InitializeComponent();
        }

        public void ClearT()
        {
            txtCodeS.ResetText();
            txtNameS.ResetText();
            txtPriceS.ResetText();
            txtTozih.ResetText();
            txtCodeS.Focus();
        }
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectService", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGService.DataSource = dt;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeS.Text))
            {
                errorProvider1.SetError(txtCodeS, "کد خدمات وارد نشده است");
            }
            else if (string.IsNullOrWhiteSpace(txtNameS.Text))
            {
                errorProvider1.SetError(txtNameS, "نام خدمات وارد نشده است");
            }
            else if (string.IsNullOrWhiteSpace(txtPriceS.Text))
            {
                errorProvider1.SetError(txtPriceS, "تعرفه خدمات وارد نشده است");
            }
            else if (string.IsNullOrWhiteSpace(txtTozih.Text))
            {
                errorProvider1.SetError(txtTozih, "توضیحات خدمات وارد نشده است");
            }
            else
            {
                if (MessageBox.Show("آیا میخواهید خدمات جدیدی با این مشخصات ثبت نمایید؟") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddService", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codes", txtCodeS.Text.Trim());
                    cmd.Parameters.AddWithValue("@names", txtNameS.Text.Trim());
                    cmd.Parameters.AddWithValue("@prices", txtPriceS.Text.Trim());
                    cmd.Parameters.AddWithValue("@tozih", txtTozih.Text.Trim());
                    cmd.Parameters.Add("@result", SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                    if (res == 1)
                    {
                        MessageBox.Show("قبلا خدمات با این کد ثبت شده است", "خطا");
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("خدمات با موفقیت ثبت شد", "ثبت");
                        ClearT();
                        Display();
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CodeS = Convert.ToInt32(txtCodeS.Text);
            if (string.IsNullOrWhiteSpace(txtCodeS.Text))
            {
                errorProvider1.SetError(txtCodeS, "کد خدمات را وارد نمایید");
            }
            else if (MessageBox.Show("آیا می خواهید خدمات انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteService", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codes", CodeS);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف خدمات با موفقیت انجام شد");
                //********************
                ClearT();
                Display();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CodeS = Convert.ToInt32(txtCodeS.Text);
            if (string.IsNullOrWhiteSpace(txtCodeS.Text))
            {
                errorProvider1.SetError(txtCodeS, "کد خدمات وارد نشده است");
            }
            else if(MessageBox.Show("آیا می خواهید این خدمات را ویرایش کنید ؟")== DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("EditService", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codes", txtCodeS.Text.Trim());
                cmd.Parameters.AddWithValue("@names", txtNameS.Text.Trim());
                cmd.Parameters.AddWithValue("@prices", txtPriceS.Text.Trim());
                cmd.Parameters.AddWithValue("@tozih", txtTozih.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش خدمات با موفقیت انجام شد");
                //********************
                ClearT();
                Display();
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
                DataTable DateT = new DataTable();
                DateT.Columns.Add("DateT");
                DateT.Rows.Add();
                DateT.Rows[0]["DateT"] = MyDate;
                //*******************************************//
                SqlDataAdapter da = new SqlDataAdapter("SelectService", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable ReportService = new DataTable();
                da.Fill(ReportService);
                //
                DataSet ds = new DataSet();
                ds.Merge(DateT);
                ds.Tables[0].TableName = "DateT";
                ds.Merge(ReportService);
                ds.Tables[1].TableName = "ReportService";
                //
                StiReportService.Load("ReportService.mrt");
                StiReportService.RegData(ds);
                StiReportService.Show();
            }

        private void FrmServiceMatab_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void DataGService_MouseUp(object sender, MouseEventArgs e)
        {
            txtCodeS.Text = DataGService[0, DataGService.CurrentRow.Index].Value.ToString();
            txtNameS.Text = DataGService[1, DataGService.CurrentRow.Index].Value.ToString();
            txtPriceS.Text = DataGService[2, DataGService.CurrentRow.Index].Value.ToString();
            txtTozih.Text = DataGService[3, DataGService.CurrentRow.Index].Value.ToString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeS.Text))
            {
                errorProvider1.SetError(txtCodeS, "کد خدمات را وارد نمایید");
                txtCodeS.Focus();
            }
            else
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from ServiceM where CodeS=@codes";
                cmd.Parameters.AddWithValue("@codes", txtCodeS.Text.Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodeS.Text = dr["CodeS"].ToString();
                    txtNameS.Text = dr["NameS"].ToString();
                    txtPriceS.Text = dr["PriceS"].ToString();
                    txtTozih.Text = dr["Tozih"].ToString();
                }
                else
                {
                    txtCodeS.ResetText();
                    MessageBox.Show("خدماتی با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }
        }
    }

