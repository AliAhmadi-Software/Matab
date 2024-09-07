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
    public partial class FrmVisit : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int IDVisit = 0;
        public FrmVisit()
        {
            InitializeComponent();
        }
        public void ClearT()
        {
            txtIDVisit.ResetText();
            //MaskDateV.ResetText();
            txtName.ResetText();
            txtNameK.ResetText();
            txtNameIn.ResetText();
            txtPriceIn.ResetText();
            txtNameS.ResetText();
            txtPriceS.ResetText();
            txtPayV.ResetText();
            txtRecipe.ResetText();
            txtIDVisit.Focus();
        }
        private void FrmVisit_Load(object sender, EventArgs e)
        {
            PersianCalendar p = new PersianCalendar();
            MaskDateV.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString() + p.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int a, b, sum = 0;
            a = Convert.ToInt32(txtPriceIn.Text);
            b = Convert.ToInt32(txtPriceS.Text);
            sum = b - a;
            txtPayV.Text = sum.ToString();
        }

        private void BtnSearchIn_Click(object sender, EventArgs e)
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
                }
                else
                {
                    txtCodeIn.ResetText();
                    MessageBox.Show("بیمه ای با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }

        private void BtnSearchS_Click(object sender, EventArgs e)
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
                }
                else
                {
                    txtCodeS.ResetText();
                    MessageBox.Show("خدماتی با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }

        private void BtnSearchIDVisit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDVisit.Text))
            {
                errorProvider1.SetError(txtIDVisit, "شماره ویزیت را وارد نمایید");
                txtCodeS.Focus();
            }
            else
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Visit where IDVisit=@idvisit";
                cmd.Parameters.AddWithValue("@idvisit", txtIDVisit.Text.Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIDVisit.Text = dr["IDVisit"].ToString();
                    MaskDateV.Text = dr["DateV"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtNameK.Text = dr["NameK"].ToString();
                    txtNameIn.Text = dr["NameIn"].ToString();
                    txtPriceIn.Text = dr["PriceIn"].ToString();
                    txtNameS.Text = dr["NameS"].ToString();
                    txtPriceS.Text = dr["PriceS"].ToString();
                    txtPayV.Text = dr["PayV"].ToString();
                    txtRecipe.Text = dr["Recipe"].ToString();
                }
                else
                {
                    txtCodeS.ResetText();
                    MessageBox.Show("ویزیتی با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDVisit.Text))
            {
                errorProvider1.SetError(txtIDVisit, "شماره ویزیت را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(MaskDateV.Text))
            {
                errorProvider1.SetError(MaskDateV, "تاریخ ویزیت را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "نام بیمار را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtNameK.Text))
            {
                errorProvider1.SetError(txtNameK, "نام خانوادگی بیمار را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtNameIn.Text))
            {
                errorProvider1.SetError(txtNameIn, "نام بیمه را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtPriceIn.Text))
            {
                errorProvider1.SetError(txtPriceIn, "تعرفه بیمه را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtNameS.Text))
            {
                errorProvider1.SetError(txtNameS, "نام خدمات را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtPriceS.Text))
            {
                errorProvider1.SetError(txtPriceS, "تعرفه خدمات را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtPayV.Text))
            {
                errorProvider1.SetError(txtPayV, "هزینه قابل پرداخت را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtRecipe.Text))
            {
                errorProvider1.SetError(txtRecipe, "نسخه پزشک را وارد نمایید");
            }
            else
            {
                if (MessageBox.Show("آیا میخواهید ویزیت با این مشخصات ثبت نمایید؟") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddVisit", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idvisit", txtIDVisit.Text.Trim());
                    cmd.Parameters.AddWithValue("@datev", MaskDateV.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@namek", txtNameK.Text.Trim());
                    cmd.Parameters.AddWithValue("@namein", txtNameIn.Text.Trim());
                    cmd.Parameters.AddWithValue("@pricein", txtPriceIn.Text.Trim());
                    cmd.Parameters.AddWithValue("@names", txtNameS.Text.Trim());
                    cmd.Parameters.AddWithValue("@prices", txtPriceS.Text.Trim());
                    cmd.Parameters.AddWithValue("@payv", txtPayV.Text.Trim());
                    cmd.Parameters.AddWithValue("@recipe", txtRecipe.Text.Trim());
                    cmd.Parameters.Add("@result", SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                    if (res == 1)
                    {
                        MessageBox.Show("قبلا این ویزیت با این شماره ویزیت ثبت شده است", "خطا");
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("ویزیت با موفقیت ثبت شد", "ثبت");
                        ClearT();
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            IDVisit = Convert.ToInt32(txtIDVisit.Text);
            if (MessageBox.Show("آیا می خواهید ویزیت انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteVisit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idvisit", IDVisit);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف ویزیت با موفقیت انجام شد");
                //********************
                ClearT();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IDVisit = Convert.ToInt32(txtIDVisit.Text);
            if (MessageBox.Show("آیا می خواهید ویزیت انتخاب شده را ویرایش کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("EditVisit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idvisit", txtIDVisit.Text.Trim());
                cmd.Parameters.AddWithValue("@datev", MaskDateV.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@namek", txtNameK.Text.Trim());
                cmd.Parameters.AddWithValue("@namein", txtNameIn.Text.Trim());
                cmd.Parameters.AddWithValue("@pricein", txtPriceIn.Text.Trim());
                cmd.Parameters.AddWithValue("@names", txtNameS.Text.Trim());
                cmd.Parameters.AddWithValue("@prices", txtPriceS.Text.Trim());
                cmd.Parameters.AddWithValue("@payv", txtPayV.Text.Trim());
                cmd.Parameters.AddWithValue("@recipe", txtRecipe.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش ویزیت با موفقیت انجام شد");
                //********************
                ClearT();
                txtIDVisit.Enabled = true;
            }
        }
    }
}
