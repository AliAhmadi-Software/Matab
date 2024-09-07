using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace Matab
{
    public partial class FrmNobat : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int Nobat = 0;
        public FrmNobat()
        {
            InitializeComponent();
        }
        public void ClearT()
        {
            txtNobat.ResetText();
            MaskDate.ResetText();
            txtName.ResetText();
            txtNameK.ResetText();
            txtTel.ResetText();
            txttozih.ResetText();
        }
        private void FrmNobat_Load(object sender, EventArgs e)
        {
            PersianCalendar p = new PersianCalendar();
            MaskDate.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString() + p.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNobat.Text))
            {
                errorProvider1.SetError(txtNobat, "شماره نوبت را وارد نمایید");
                txtNobat.Focus();
            }
            else if (string.IsNullOrWhiteSpace(MaskDate.Text))
            {
                errorProvider1.SetError(MaskDate, "نام بیمار را وارد نمایید");

            }
            else if (string.IsNullOrWhiteSpace(txtNameK.Text))
            {
                errorProvider1.SetError(txtNameK, "نام خانوادگی بیمار را وارد نمایید");

            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "نام بیمار  را وارد نمایید");

            }
            else if (string.IsNullOrWhiteSpace(txtTel.Text))
            {
                errorProvider1.SetError(txtTel, "تلفن بیمار را وارد نمایید");

            }
            else if (string.IsNullOrWhiteSpace(txttozih.Text))
            {
                errorProvider1.SetError(txttozih, "توضیحات را وارد نمایید\n" + "یا در صورت نداشتن \n" + "ندارد را وارد کنید");

            }
            else
            {
                if (MessageBox.Show("آیا میخواهید نوبت با این مشخصات ثبت نمایید؟") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddNobat", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nobat", txtNobat.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", MaskDate.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@namek", txtNameK.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", txtTel.Text.Trim());
                    cmd.Parameters.AddWithValue("@tozih", txttozih.Text.Trim());
                    cmd.Parameters.Add("@result", SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                    if (res == 1)
                    {
                        MessageBox.Show("قبلا این نوبت ثبت شده است", "خطا");
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("نوبت با موفقیت ثبت شد", "ثبت");
                        ClearT();
                        SqlDataAdapter da = new SqlDataAdapter("SelectNobat", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Frm1 fmain = new Frm1();
                        fmain.DataGNobat.DataSource = dt;
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Nobat = Convert.ToInt32(txtNobat.Text);
            if (MessageBox.Show("آیا می خواهید نوبت انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteNobat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nobat", Nobat);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف نوبت با موفقیت انجام شد");
                //********************
                ClearT();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Nobat = Convert.ToInt32(txtNobat.Text);
            if (MessageBox.Show("آیا می خواهید نوبت انتخاب شده را ویرایش کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("EditNobat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nobat", txtNobat.Text.Trim());
                cmd.Parameters.AddWithValue("@date", MaskDate.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@namek", txtNameK.Text.Trim());
                cmd.Parameters.AddWithValue("@tel", txtTel.Text.Trim());
                cmd.Parameters.AddWithValue("@tozih", txttozih.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش نوبت با موفقیت انجام شد");
                //********************
                ClearT();
                txtNobat.Enabled = true;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNobat.Text))
            {
                errorProvider1.SetError(txtNobat, "شماره نوبت را وارد نمایید");
                txtNobat.Focus();
            }
            else
            {
                txtNobat.Enabled = false;
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Nobat where Nobat=@nobat";
                cmd.Parameters.AddWithValue("@nobat", txtNobat.Text.Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MaskDate.Text = dr["DateN"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtNameK.Text = dr["NameK"].ToString();
                    txtTel.Text = dr["Tel"].ToString();
                    txttozih.Text = dr["tozih"].ToString();
                }
                else
                {
                    txtNobat.Enabled = true;
                    txtNobat.ResetText();
                    MessageBox.Show("منشی با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }
    }
}
