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
    public partial class FrmFile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int CodeF = 0;
        public FrmFile()
        {
            InitializeComponent();
        }
        public void ClearT()
        {
            txtCodeF.ResetText();
            txtName.ResetText();
            txtNameK.ResetText();
            txtNameIn.ResetText();
            txtPriceIn.ResetText();
            txtillNow.ResetText();
            txtillPast.ResetText();
            txtRecipe.ResetText();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeF.Text))
            {
                errorProvider1.SetError(txtCodeF, "شماره ویزیت را وارد نمایید");
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
            if (string.IsNullOrWhiteSpace(ComboSex.Text))
            {
                errorProvider1.SetError(ComboSex, "لطفا جنسیت بیمار را انتخاب کنید");
            }
            if (string.IsNullOrWhiteSpace(txtillPast.Text))
            {
                errorProvider1.SetError(txtillPast, "نام خدمات را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtillNow.Text))
            {
                errorProvider1.SetError(txtillNow, "تعرفه خدمات را وارد نمایید");
            }
            if (string.IsNullOrWhiteSpace(txtRecipe.Text))
            {
                errorProvider1.SetError(txtRecipe, "نسخه پزشک را وارد نمایید");
            }
            else
            {
                if (MessageBox.Show("آیا میخواهید پرونده ای با این مشخصات ثبت نمایید؟") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddFileSick", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codef", txtCodeF.Text.Trim());
                    cmd.Parameters.AddWithValue("@datef", MaskDateF.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@namek", txtNameK.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateb", MaskDateB.Text);
                    cmd.Parameters.AddWithValue("@sex", ComboSex.Text);
                    cmd.Parameters.AddWithValue("@datenow", MaskDateNow.Text);
                    cmd.Parameters.AddWithValue("@dateafter", MaskDateAfter.Text);
                    cmd.Parameters.AddWithValue("@namein", txtNameIn.Text.Trim());
                    cmd.Parameters.AddWithValue("@pricein", txtPriceIn.Text.Trim());
                    cmd.Parameters.AddWithValue("@illpast", txtillPast.Text.Trim());
                    cmd.Parameters.AddWithValue("@illnow", txtillNow.Text.Trim());
                    cmd.Parameters.AddWithValue("@recipe", txtRecipe.Text.Trim());
                    cmd.Parameters.Add("@result", SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                    if (res == 1)
                    {
                        MessageBox.Show("قبلا این پرونده با این شماره پرونده ثبت شده است", "خطا");
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("پرونده با موفقیت ثبت شد", "ثبت");
                        ClearT();
                    }
                }
            }
        }

        private void FrmFile_Load(object sender, EventArgs e)
        {
            PersianCalendar p = new PersianCalendar();
            MaskDateF.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString() + p.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CodeF = Convert.ToInt32(txtCodeF.Text);
            if (MessageBox.Show("آیا می خواهید پرونده انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteFileS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codef", CodeF);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف پرونده با موفقیت انجام شد");
                //********************
                ClearT();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CodeF = Convert.ToInt32(txtCodeF.Text);
            if (MessageBox.Show("آیا میخواهید پرونده ای با این مشخصات را ویرایش نمایید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("EditFileS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codef", txtCodeF.Text.Trim());
                cmd.Parameters.AddWithValue("@datef", MaskDateF.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@namek", txtNameK.Text.Trim());
                cmd.Parameters.AddWithValue("@dateb", MaskDateB.Text);
                cmd.Parameters.AddWithValue("@sex", ComboSex.Text);
                cmd.Parameters.AddWithValue("@datenow", MaskDateNow.Text);
                cmd.Parameters.AddWithValue("@dateafter", MaskDateAfter.Text);
                cmd.Parameters.AddWithValue("@namein", txtNameIn.Text.Trim());
                cmd.Parameters.AddWithValue("@pricein", txtPriceIn.Text.Trim());
                cmd.Parameters.AddWithValue("@illpast", txtillPast.Text.Trim());
                cmd.Parameters.AddWithValue("@illnow", txtillNow.Text.Trim());
                cmd.Parameters.AddWithValue("@recipe", txtRecipe.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش پرونده با موفقیت انجام شد");
                //********************
                ClearT();
            }
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

        private void BtnSearchCodeF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeF.Text))
            {
                errorProvider1.SetError(txtCodeF, "شماره ویزیت را وارد نمایید");
                txtCodeF.Focus();
            }
            else
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from FileSick where CodeF=@codef";
                cmd.Parameters.AddWithValue("@codef", txtCodeF.Text.Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodeF.Text = dr["CodeF"].ToString();
                    MaskDateF.Text = dr["DateF"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtNameK.Text = dr["NameK"].ToString();
                    MaskDateB.Text = dr["DateB"].ToString();
                    ComboSex.Text = dr["Sex"].ToString();
                    MaskDateNow.Text = dr["DateNow"].ToString();
                    MaskDateAfter.Text = dr["DateAfter"].ToString();
                    txtNameIn.Text = dr["NameIn"].ToString();
                    txtPriceIn.Text = dr["PriceIn"].ToString();
                    txtillPast.Text = dr["illPast"].ToString();
                    txtillNow.Text = dr["illNow"].ToString();
                    txtRecipe.Text = dr["Recipe"].ToString();
                }
                else
                {
                    txtCodeF.ResetText();
                    MessageBox.Show("پرونده ای با این مشخصات وجود ندارد");
                }
                con.Close();
            }
        }
    }
}

