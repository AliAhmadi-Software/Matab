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
    public partial class FrmMonshi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int ID = 0;
        public void ClearT()
        {
            txtCodeMonshi.ResetText();
            txtNameMonshi.ResetText();
            txtNameK.ResetText();
            txtCodeM.ResetText();
            txtSalary.ResetText();
            txtTel.ResetText();
            txtTozih.ResetText();
            MaskDateB.ResetText();
            MaskDateE.ResetText();
            MaskSalary.ResetText();
            //***************************
            txtCodeMonshi.Focus();
        }
        public FrmMonshi()
        {
            InitializeComponent();
        }

        private void FrmMonshi_Load(object sender, EventArgs e)
        {
            PersianCalendar p = new PersianCalendar();
            MaskDateE.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString() + p.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeMonshi.Text))
            {
                errorProvider1.SetError(txtCodeMonshi, "کد منشی را وارد نمایید");
                txtCodeMonshi.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtNameMonshi.Text))
            {
                errorProvider1.SetError(txtNameMonshi, "نام منشی را وارد نمایید");
                //txtNameMonshi.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtNameK.Text))
            {
                errorProvider1.SetError(txtNameK, "نام خانوادگی منشی را وارد نمایید");
                //txtNameK.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtCodeM.Text))
            {
                errorProvider1.SetError(txtCodeM, "کد ملی منشی را وارد نمایید");
                //txtCodeM.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                errorProvider1.SetError(txtSalary, "حقوق منشی را وارد نمایید");
                //txtSalary.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTel.Text))
            {
                errorProvider1.SetError(txtTel, "تلفن منشی را وارد نمایید");
                //txtTozih.Focus();
            }
            else if (string.IsNullOrWhiteSpace(MaskDateB.Text))
            {
                errorProvider1.SetError(MaskDateB, "تاریخ تولد را وارد نمایید");
                //MaskDateB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(MaskDateE.Text))
            {
                errorProvider1.SetError(MaskDateE, "تاریخ استخدام را وارد نمایید");
                //MaskDateE.Focus();
            }
            else if (string.IsNullOrWhiteSpace(MaskSalary.Text))
            {
                errorProvider1.SetError(MaskSalary, "تاریخ پرداخت حقوق را وارد نمایید");
                //MaskSalary.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTozih.Text))
            {
                errorProvider1.SetError(txtTel, "توضیحات را وارد نمایید\n" + "یا در صورت نداشتن \n" + "ندارد را وارد کنید");
                //txtTel.Focus();
            }
            else
            {
                if (MessageBox.Show("آیا میخواهید منشی با این مشخصات ثبت نمایید؟") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddMonshi", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idmonshi", txtCodeMonshi.Text.Trim());
                    cmd.Parameters.AddWithValue("@namemonshi", txtNameMonshi.Text.Trim());
                    cmd.Parameters.AddWithValue("@namek", txtNameK.Text.Trim());
                    cmd.Parameters.AddWithValue("@codem", txtCodeM.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", txtTel.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateb", MaskDateB.Text);
                    cmd.Parameters.AddWithValue("@datee", MaskDateE.Text);
                    cmd.Parameters.AddWithValue("@salary", txtSalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@datesalary", MaskSalary.Text);
                    cmd.Parameters.AddWithValue("@tozih", txtTozih.Text.Trim());
                    cmd.Parameters.Add("@result", SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                    if (res == 1)
                    {
                        MessageBox.Show("قبلا منشی با این کد ثبت شده است", "خطا");
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("منشی با موفقیت ثبت شد", "ثبت");
                        ClearT();
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(txtCodeMonshi.Text);
            if (MessageBox.Show("آیا می خواهید تنظیم انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteMonshi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmonshi", ID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف مدیر با موفقیت انجام شد");
                //********************
                ClearT();
                BtnSave.Enabled = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(txtCodeMonshi.Text);
            if (MessageBox.Show("آیا می خواهید منشی انتخاب شده را ویرایش کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("EditMonshi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmonshi", ID);
                cmd.Parameters.AddWithValue("@namemonshi", txtNameMonshi.Text.Trim());
                cmd.Parameters.AddWithValue("@namek", txtNameK.Text.Trim());
                cmd.Parameters.AddWithValue("@codem", txtCodeM.Text.Trim());
                cmd.Parameters.AddWithValue("@tel", txtTel.Text.Trim());
                cmd.Parameters.AddWithValue("@dateb", MaskDateB.Text);
                cmd.Parameters.AddWithValue("@datee", MaskDateE.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text.Trim());
                cmd.Parameters.AddWithValue("@datesalary", MaskSalary.Text);
                cmd.Parameters.AddWithValue("@tozih", txtTozih.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش منشی با موفقیت انجام شد");
                //********************
                ClearT();
                BtnSave.Enabled = true;                
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeMonshi.Text))
            {
                errorProvider1.SetError(txtCodeMonshi, "کد منشی را وارد نمایید");
                txtCodeMonshi.Focus();
            }
            else
            {
                //SqlDataAdapter da = new SqlDataAdapter("SelectMonshi", con);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //cmd=new SqlCommand();   
                //cmd.Parameters.AddWithValue("@idmonshi", txtCodeMonshi.Text);
                //con.Open();
                //cmd.ExecuteReader();
                //SqlDataReader ds;
                //if (ds.Read())
                //{
                //    txtCodeMonshi.Text = ds["IDMonshi"].ToString();
                //    txtNameMonshi.Text = ds["NameMonshi"].ToString();
                //    txtNameK.Text = ds["NameK"].ToString();
                //    txtCodeM.Text = ds["CodeM"].ToString();
                //    txtTel.Text = ds["Tel"].ToString();
                //    MaskDateB.Text = ds["DateB"].ToString();
                //    MaskDateE.Text = ds["DateE"].ToString();
                //    txtSalary.Text = ds["Salary"].ToString();
                //    MaskSalary.Text = ds["DateSalary"].ToString();
                //    txtTozih.Text = ds["Tozih"].ToString();
                //}
                //else
                //{
                //    txtCodeMonshi.ResetText();
                //    MessageBox.Show("منشی با این مشخصات وجود ندارد");
                //}
                //con.Close();

                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Monshi where IDMonshi=@ID";
                cmd.Parameters.AddWithValue("@ID", txtCodeMonshi.Text.Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodeMonshi.Text = dr["IDMonshi"].ToString();
                    txtNameMonshi.Text = dr["NameMonshi"].ToString();
                    txtNameK.Text = dr["NameK"].ToString();
                    txtCodeM.Text = dr["CodeM"].ToString();
                    txtTel.Text = dr["Tel"].ToString();
                    MaskDateB.Text = dr["DataB"].ToString();
                    MaskDateE.Text = dr["DateE"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();
                    MaskSalary.Text = dr["DateSalary"].ToString();
                    txtTozih.Text = dr["Tozih"].ToString();
                }
                else
                {
                    txtCodeMonshi.ResetText();
                    MessageBox.Show("منشی با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }
    }
}
