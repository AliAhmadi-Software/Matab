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
    public partial class Frmlogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MatabDB; Integrated Security=true");
        //public static string User;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "نام کاربری را وارد نمایید");
                txtUserName.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtPasword.Text))
            {
                errorProvider1.SetError(txtPasword, "رمز عبور را وارد نمایید");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SearchForLogin", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                da.SelectCommand.Parameters.AddWithValue("@pasword", txtPasword.Text.Trim());
                da.SelectCommand.Parameters.AddWithValue("@acess", CmbAcess.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("نام کاربری یا کلمه عبور و یا سطح دسترسی صحیح نیست ");
                    txtPasword.ResetText();
                    txtUserName.ResetText();
                    txtUserName.Focus();
                }
                else
                {
                    Frm1 fmain = new Frm1();
                    fmain.LblUser.Text = txtUserName.Text;
                    if (CmbAcess.Text == "کاربر عادی")
                    {
                        fmain.BtnKarbar.Enabled = false;
                        fmain.BtnSetting.Enabled = false;
                        fmain.BtnPay.Enabled = false;
                        fmain.BtnMonshi.Enabled = false;
                    }
                    fmain.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            frmlogo flogo = new frmlogo();
            flogo.ShowDialog();
        }
    }
}
