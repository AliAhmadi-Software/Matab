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
    public partial class FrmInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        int ID = 0;
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllInfo", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridInfo.DataSource = dt;
            //*********************************
            txtCodeD.ResetText();
            txtNameDoc.ResetText();
            txtNameMatab.ResetText();
            txtTel.ResetText();
            txtMobile.ResetText();
            txtAdress.ResetText();
            txtCodeD.Focus();
        }
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodeD.Text))
            {
                errorProvider1.SetError(txtCodeD, "کد نظام پزشکی را وارد نمایید");
                txtCodeD.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtNameDoc.Text))
            {
                errorProvider1.SetError(txtNameDoc, "نام پزشک را وارد نمایید");
                txtNameDoc.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtNameMatab.Text))
            {
                errorProvider1.SetError(txtNameMatab, "نام مطب را وارد نمایید");
                txtNameMatab.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTel.Text))
            {
                errorProvider1.SetError(txtTel, "تلفن را وارد نمایید");
                txtTel.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTel.Text))
            {
                errorProvider1.SetError(txtTel, "شماره موبایل  را وارد نمایید");
                txtTel.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtAdress.Text))
            {
                errorProvider1.SetError(txtAdress, "آدرس را وارد نمایید");
                txtAdress.Focus();
            }
            else
            {
                if (MessageBox.Show("آیا میخواهید تنظیم جدیدی را ثبت کنید؟") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codedoc", txtCodeD.Text.Trim());
                    cmd.Parameters.AddWithValue("@namedoc", txtNameDoc.Text.Trim());
                    cmd.Parameters.AddWithValue("@namematab", txtNameMatab.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", txtTel.Text.Trim());
                    cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@adres", txtAdress.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //******************
                    MessageBox.Show("تنظیمات جدید با موفقیت ثبت شد");
                    Display();
                }
            }
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید تنظیم انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",ID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف تنظیمات با موفقیت انجام شد");
                //********************
                Display();
                BtnSave.Enabled = true;
            }
        }

        private void DataGridInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnSave.Enabled = false;
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            txtCodeD.Text = DataGridInfo.CurrentRow.Cells["CodeDoc"].Value.ToString();
            txtNameDoc.Text = DataGridInfo.CurrentRow.Cells["NameDoc"].Value.ToString();
            txtNameMatab.Text = DataGridInfo.CurrentRow.Cells["NameMatab"].Value.ToString();
            txtTel.Text = DataGridInfo.CurrentRow.Cells["tel"].Value.ToString();
            txtMobile.Text = DataGridInfo.CurrentRow.Cells["Mobile"].Value.ToString();
            txtAdress.Text = DataGridInfo.CurrentRow.Cells["Adres"].Value.ToString();
            ID = Convert.ToInt32(DataGridInfo.CurrentRow.Cells["Id"].Value);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید تنظیم انتخاب شده را ویرایش کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("EditInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@codedoc", txtCodeD.Text.Trim());
                cmd.Parameters.AddWithValue("@namedoc", txtNameDoc.Text.Trim());
                cmd.Parameters.AddWithValue("@namematab", txtNameMatab.Text.Trim());
                cmd.Parameters.AddWithValue("@tel", txtTel.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());
                cmd.Parameters.AddWithValue("@adres", txtAdress.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش تنظیم با موفقیت انجام شد");
                //********************
                Display();
                BtnSave.Enabled = true;
            }
        }
    }
}
