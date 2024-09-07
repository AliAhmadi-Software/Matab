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
    public partial class FrmCostMatab : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int CodeC = 0;
        public FrmCostMatab()
        {
            InitializeComponent();
        }
        public void ClearT()
        {
            txtCode.ResetText();
            txtExplainC.ResetText();
            txtPrice.ResetText();
            txtName.ResetText();
            txtTozih.ResetText();
            txtCode.Focus();
        }

        private void FrmCostMatab_Load(object sender, EventArgs e)
        {
            PersianCalendar p = new PersianCalendar();
            MaskDateC.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString() + p.GetDayOfMonth(DateTime.Now).ToString();
            //txtPrice.Text = Convert.ToInt32(txtPrice.Text).ToString("000,000,000,000,000");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                errorProvider1.SetError(txtCode, "کد هزینه را وارد نمایید");
                txtCode.Focus();
            }
            else
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from CostM where CodeCostM=@Code";
                cmd.Parameters.AddWithValue("@Code", txtCode.Text.Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCode.Text = dr["CodeCostM"].ToString();
                    txtExplainC.Text = dr["ExplainC"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    MaskDateC.Text = dr["DateC"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtTozih.Text = dr["tozih"].ToString();
                }
                else
                {
                    txtCode.Enabled = true;
                    txtCode.ResetText();
                    MessageBox.Show("هزینه ای با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                errorProvider1.SetError(txtCode, "کد هزینه را وارد نمایید");
                txtCode.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtExplainC.Text))
            {
                errorProvider1.SetError(txtExplainC, "شرح هزینه را وارد نمایید");

            }
            else if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                errorProvider1.SetError(txtPrice, "مبلغ هزینه را وارد نمایید");

            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "نام شخص  را وارد نمایید");

            }
            else if (string.IsNullOrWhiteSpace(txtTozih.Text))
            {
                errorProvider1.SetError(txtTozih, "توضیحات را وارد نمایید");

            }
            else
            {
                if (MessageBox.Show("آیا میخواهید هزینه ای با این مشخصات ثبت نمایید؟") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddCostM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@code", txtCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@explain", txtExplainC.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                    cmd.Parameters.AddWithValue("@datec", MaskDateC.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@tozih", txtTozih.Text.Trim());
                    cmd.Parameters.Add("@result", SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                    if (res == 1)
                    {
                        MessageBox.Show("قبلا این هزینه با این کد ثبت شده است", "خطا");
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("هزینه با موفقیت ثبت شد", "ثبت");
                        ClearT();
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CodeC = Convert.ToInt32(txtCode.Text);
            if (MessageBox.Show("آیا می خواهید هزینه انتخاب شده را ویرایش کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("EditCostM", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", txtCode.Text.Trim());
                cmd.Parameters.AddWithValue("@explain", txtExplainC.Text.Trim());
                cmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@datec", MaskDateC.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@tozih", txtTozih.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش هزینه با موفقیت انجام شد");
                //********************
                ClearT();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CodeC = Convert.ToInt32(txtCode.Text);
            if (MessageBox.Show("آیا می خواهید هزینه انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteCostM", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", CodeC);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف هزینه با موفقیت انجام شد");
                //********************
                ClearT();
            }
        }
    }
}
