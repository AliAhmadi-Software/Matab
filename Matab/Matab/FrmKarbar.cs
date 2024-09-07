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
    public partial class FrmKarbar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        public void Display()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectAllKarbar", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridKarbar.DataSource = dt;
            txtUserName.ResetText();
            txtPasword.ResetText();
            txtUserName.Focus();
        }
        public FrmKarbar()
        {
            InitializeComponent();
        }

        private void FrmKarbar_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "نام کاربری وارد نشده است");
                txtUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPasword.Text))
            {
                errorProvider1.SetError(txtPasword, "رمز عبور وارد نشده است");
                txtPasword.Focus();
            }
            else
            {
                if (MessageBox.Show("آیا کاربر جدیدی می خواهید ثبت کنید؟", "ثبت کاربر") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("AddUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username",txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@pasword", txtPasword.Text.Trim());
                    cmd.Parameters.AddWithValue("@acess", CmbAcess.Text);
                    cmd.Parameters.Add("@result", SqlDbType.Int);
                    cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    int res = Convert.ToInt32(cmd.Parameters["@result"].Value);
                    if (res == 1)
                    {
                        MessageBox.Show("نام کاربری قبلا در سیستم ثبت شده است", "خطا");
                        txtUserName.ResetText();
                        txtPasword.ResetText();
                        txtUserName.Focus();
                    }
                    else if (res == 0)
                    {
                        Display();
                        //***********
                        MessageBox.Show("ثبت کاربر با موفقیت انجام شد");
                    }
            }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید کاربر انتخاب شده را حذف کنید؟") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("DeleteKarbar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف مدیر با موفقیت انجام شد");
                //********************
                Display();
                txtUserName.Enabled = true;
                BtnSave.Enabled = true;
            }
        }

        private void DataGridKarbar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnSave.Enabled = false;
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            txtUserName.Text = DataGridKarbar.CurrentRow.Cells["username"].Value.ToString();
            txtPasword.Text = DataGridKarbar.CurrentRow.Cells["pasword"].Value.ToString();
            CmbAcess.Text = DataGridKarbar.CurrentRow.Cells["acess"].Value.ToString();
            txtUserName.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "نام کاربری وارد نشده است");
                txtUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPasword.Text))
            {
                errorProvider1.SetError(txtPasword, "رمز عبور وارد نشده است");
                txtPasword.Focus();
            }
            else
            {
                if (MessageBox.Show("آیا کاربر انتخاب شده را می خواهید ویرایش کنید؟", "ویرایش کاربر") == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("EditKarbar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@pasword", txtPasword.Text.Trim());
                    cmd.Parameters.AddWithValue("@acess", CmbAcess.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //*********************
                    MessageBox.Show("ویرایش کاربر با موفقیت انجام شد");
                    Display();
                    txtUserName.Enabled = true;
                    BtnSave.Enabled = true;
                }

            }
        }
    }
}
